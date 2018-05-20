﻿using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class ViewCars : Form {
        readonly DbManager _mgr = new DbManager();
        public ViewCars() {
            InitializeComponent();
            refreshCarList();
        }


        void refreshCarList() {
            try {
                Cars.DataSource = _mgr.GetCars();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load Car List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RemoveCar_Click(Object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = CarGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (CarEntity)rows[0].DataBoundItem;
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

        void AddCar_Click(Object sender, EventArgs e) {
            var dlg = new AddNewCar();
            dlg.ShowDialog(this);
            if (dlg.AddedCar != null) {
                Cars.Add(dlg.AddedCar);
            }
        }

        void EditCar_Click(Object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = CarGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (CarEntity)rows[0].DataBoundItem;
            var dlg = new EditCar(car);
            dlg.ShowDialog(this);
            refreshCarList();
        }

        void RefreshCarListButton_Click(Object sender, EventArgs e) {
            refreshCarList();
        }
    }
}
