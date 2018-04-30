using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class AddNewCar : Form {
        readonly CarEntity _car = new CarEntity {
            Year = 2000
        };
        public AddNewCar() {
            InitializeComponent();
            GearUnitTypeBox.DataSource = Enum.GetValues(typeof(GearUnitType));
            GearUnitTypeBox.DataBindings.Add(nameof(ComboBox.SelectedItem), _car, nameof(CarEntity.GearUnitType));
            RegNumberBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.RegNumber));
            VendorBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.Vendor));
            ModelBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.Model));
            YearBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.Year));
            RentPricePerDayBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.RentPricePerDay));
        }



        private void ButtonSave_Click(object sender, EventArgs e) {

        }
    }
}
