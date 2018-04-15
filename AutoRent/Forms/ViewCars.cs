using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class ViewCars : Form
    {
        readonly DbManager _mgr = new DbManager();
        public ViewCars()
        {
            InitializeComponent();
            Cars.DataSource = _mgr.GetCars();
        }


        
        void DeleteCar_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Confirm deletion...", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }
        }
    }
}
