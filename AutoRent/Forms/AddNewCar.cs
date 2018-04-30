using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    public partial class AddNewCar : Form {
        public AddNewCar() {
            InitializeComponent();
            GearUnitTypeBox.DataSource = Enum.GetValues(typeof(GearUnitType));
        }


    }
}
