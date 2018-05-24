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
            _client = client;
            RefreshTables();
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
        }
        void RefreshTables() {
            try {
                AvailableCarList.DataSource = _mgr.GetFreeCars();
                RentedCarList.DataSource = _mgr.GetClientWithRents(_client.ID).Rents.Select(x => new CarRentViewModel(x));
                RentButton.Enabled = RentedCarList.Count < 5;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load Car List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void TextBoxIntegerKeyPress(Object sender, KeyPressEventArgs e) {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void OnCalculatePriceButtonClick(Object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = FreeCarGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (CarEntity)rows[0].DataBoundItem;
            PriceBox.Text = car.RentPricePerDay * Convert.ToInt32(CountOfDaysBox.Text) + " EUR";
        }

        void RentCarButton_Click(Object sender, EventArgs e) {
            Int32.TryParse(CountOfDaysBox.Text, NumberStyles.Any, null, out Int32 countOfDays);

            try {
                DataGridViewSelectedRowCollection rows = FreeCarGridView.SelectedRows;
                if (rows.Count == 0 || countOfDays == 0 || !(rows[0].DataBoundItem is CarEntity car)) { return; }

                var carRent = new CarRent {
                    CarID = car.ID,
                    ClientID = _client.ID,
                    LeaseStarted = DateTime.Now,
                    LeaseEnded = DateTime.Now.AddDays(Convert.ToInt32(CountOfDaysBox.Text))
                };
                _mgr.RentCar(carRent);
                RefreshTables();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Rent Car Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
