using System;
using System.Linq;
using System.Windows.Forms;
using AutoRent.Database;
using AutoRent.Models;

namespace AutoRent.Forms {
    partial class ReturnCar : Form {
        readonly DbManager _mgr = new DbManager();
        readonly ClientEntity _client;
        public ReturnCar(ClientEntity client) {
            InitializeComponent();
            _client = client;
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
            refreshLists();
        }
        void refreshLists() {
            try {
                RentedCarList.DataSource = _mgr.GetClientWithRents(_client.ID).Rents.Select(x => new CarRentViewModel(x));
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load Car List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ButtonReturn_Click(Object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = RentedCarGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (CarRentViewModel)rows[0].DataBoundItem;
            Int32 diff = (DateTime.Now - car.LeaseEnded.Value).Days;
            if (diff > 0) {
                MessageBox.Show($"Car lease expired. Penalty fee for {diff} days: {diff * car.RentPricePerDay} EUR", "Return Car", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try {
                _mgr.ReturnCar(car.ID);
                refreshLists();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Return Car Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
