using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class RentCar : Form {
        readonly DbManager _mgr = new DbManager();
        readonly ClientEntity _client;
        public RentCar(ClientEntity client) {
            InitializeComponent();
            refreshCarList();
            _client = client;
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
        }
        void refreshCarList() {
            try {
                Cars.DataSource = _mgr.GetFreeCars();
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
    }
}
