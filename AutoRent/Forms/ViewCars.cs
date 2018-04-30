using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class ViewCars : Form {
        readonly DbManager _mgr = new DbManager();
        public ViewCars() {
            InitializeComponent();
            Cars.DataSource = _mgr.GetCars();
        }



        void RemoveCar_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = CarGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            CarEntity car = (CarEntity)rows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("Confirm deletion...", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) {
                return;
            }

            try {
                _mgr.RemoveCar(car);
                Cars.Remove(car);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Remove Car Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var dlg = new AddNewCar();
            dlg.ShowDialog(this);
        }

        private void EditCar_Click(object sender, EventArgs e)
        {
            var dlg = new EditCar();
            dlg.ShowDialog(this);
        }
    }
}
