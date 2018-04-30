using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    public partial class AddNewCar : Form {
        readonly CarEntity _car = new CarEntity();
        public AddNewCar() {
            InitializeComponent();
            GearUnitTypeBox.DataSource = Enum.GetValues(typeof(GearUnitType));
            GearUnitTypeBox.DataBindings.Add(nameof(ComboBox.SelectedItem), _car.GearUnitType, nameof(CarEntity.GearUnitType));
            RegNumberBox.DataBindings.Add(nameof(TextBox.Text), _car.RegNumber, nameof(CarEntity.RegNumber));
            VendorBox.DataBindings.Add(nameof(TextBox.Text), _car.Vendor, nameof(CarEntity.Vendor));
            ModelBox.DataBindings.Add(nameof(TextBox.Text), _car.Model, nameof(CarEntity.Model));
            YearBox.DataBindings.Add(nameof(TextBox.Text), _car.Year, nameof(CarEntity.Year));
            RentPricePerDayBox.DataBindings.Add(nameof(TextBox.Text), _car.RentPricePerDay, nameof(CarEntity.RentPricePerDay));
        }



        private void ButtonSave_Click(object sender, EventArgs e) {

        }
    }
}
