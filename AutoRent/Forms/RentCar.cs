using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AutoRent.Database;
using AutoRent.Models;

namespace AutoRent.Forms {
    partial class RentCar : Form {
        readonly DbManager _mgr = new DbManager();
        readonly ClientEntity _client;

        public RentCar(ClientEntity client) {
            InitializeComponent();
            _client = _mgr.GetClientWithRents(client.ID);
            refreshCarList();
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
        }
        void refreshCarList() {
            try {
                AvailableCarList.DataSource = _mgr.GetFreeCars();
                RentedCarList.DataSource = _client.Rents.Select(x => new CarRentViewModel(x));
                if (_client.Rents.Count < 5) {
                    RentButton.Enabled = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load Car List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TextBoxIntegerKeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void OnCalculatePriceButtonClick(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = FreeCarGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (CarEntity)rows[0].DataBoundItem;
            PriceBox.Text = car.RentPricePerDay * Convert.ToInt32(CountOfDaysBox.Text) + " EUR";
        }

        void OnRentButtonClick(object sender, EventArgs e)
        {
            int countOfDays;
            int.TryParse(CountOfDaysBox.Text, NumberStyles.Any, null, out countOfDays);

            DataGridViewSelectedRowCollection rows = FreeCarGridView.SelectedRows;
            if (rows.Count == 0 || countOfDays == 0)
            { return; }
            var car = (CarEntity)rows[0].DataBoundItem;

            var carRent = new CarRent
            {
                CarID = car.ID,
                ClientID = _client.ID,
                LeaseStarted = DateTime.Now,
                LeaseEnded = DateTime.Now.AddDays(Convert.ToInt32(CountOfDaysBox.Text))
            };
        }


    }
}
