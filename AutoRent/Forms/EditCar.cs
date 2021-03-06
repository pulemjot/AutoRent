﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class EditCar : Form {
        readonly DbManager _mgr = new DbManager();
        readonly CarEntity _car;
        public EditCar(CarEntity car) {
            InitializeComponent();
            _car = car;
            GearUnitTypeBox.DataSource = Enum.GetValues(typeof(GearUnitType));
            GearUnitTypeBox.DataBindings.Add(nameof(ComboBox.SelectedItem), _car, nameof(CarEntity.GearUnitType));
            RegNumberBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.RegNumber));
            VendorBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.Vendor));
            ModelBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.Model));
            YearBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.Year));
            RentPricePerDayBox.DataBindings.Add(nameof(TextBox.Text), _car, nameof(CarEntity.RentPricePerDay));
        }

        void ButtonSave_Click(Object sender, EventArgs e) {
            if (!ValidateForm()) {
                return;
            }

            try {
                _mgr.EditCar(_car);
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Save car error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ValidateForm() {
            var ctx = new ValidationContext(_car);
            IList<ValidationResult> errors = new List<ValidationResult>();
            var sb = new StringBuilder();
            if (Validator.TryValidateObject(_car, ctx, errors, true)) {
                return true;
            }

            foreach (ValidationResult result in errors) {
                sb.AppendLine(result.ErrorMessage);
            }

            MessageBox.Show(sb.ToString(), "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }
    }
}
