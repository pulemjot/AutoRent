using System.Windows.Forms;

namespace AutoRent.Forms
{
    partial class AddNewCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RegNumber = new System.Windows.Forms.Label();
            this.Vendor = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.GearUnitType = new System.Windows.Forms.Label();
            this.RentPricePerDay = new System.Windows.Forms.Label();
            this.RegNumberBox = new System.Windows.Forms.TextBox();
            this.VendorBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.RentPricePerDayBox = new System.Windows.Forms.TextBox();
            this.GearUnitTypeBox = new System.Windows.Forms.ComboBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.carEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RegNumber
            // 
            this.RegNumber.AutoSize = true;
            this.RegNumber.Location = new System.Drawing.Point(12, 16);
            this.RegNumber.Name = "RegNumber";
            this.RegNumber.Size = new System.Drawing.Size(103, 13);
            this.RegNumber.TabIndex = 0;
            this.RegNumber.Text = "Registration Number";
            // 
            // Vendor
            // 
            this.Vendor.AutoSize = true;
            this.Vendor.Location = new System.Drawing.Point(12, 44);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(41, 13);
            this.Vendor.TabIndex = 1;
            this.Vendor.Text = "Vendor";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(12, 75);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 2;
            this.Model.Text = "Model";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(12, 105);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 3;
            this.Year.Text = "Year";
            // 
            // GearUnitType
            // 
            this.GearUnitType.AutoSize = true;
            this.GearUnitType.Location = new System.Drawing.Point(12, 134);
            this.GearUnitType.Name = "GearUnitType";
            this.GearUnitType.Size = new System.Drawing.Size(79, 13);
            this.GearUnitType.TabIndex = 4;
            this.GearUnitType.Text = "Gear Unit Type";
            // 
            // RentPricePerDay
            // 
            this.RentPricePerDay.AutoSize = true;
            this.RentPricePerDay.Location = new System.Drawing.Point(12, 162);
            this.RentPricePerDay.Name = "RentPricePerDay";
            this.RentPricePerDay.Size = new System.Drawing.Size(98, 13);
            this.RentPricePerDay.TabIndex = 5;
            this.RentPricePerDay.Text = "Rent Price Per Day";
            // 
            // RegNumberBox
            // 
            this.RegNumberBox.Location = new System.Drawing.Point(188, 16);
            this.RegNumberBox.Name = "RegNumberBox";
            this.RegNumberBox.Size = new System.Drawing.Size(121, 20);
            this.RegNumberBox.TabIndex = 6;
            // 
            // VendorBox
            // 
            this.VendorBox.Location = new System.Drawing.Point(188, 44);
            this.VendorBox.Name = "VendorBox";
            this.VendorBox.Size = new System.Drawing.Size(121, 20);
            this.VendorBox.TabIndex = 7;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(188, 75);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(121, 20);
            this.ModelBox.TabIndex = 8;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(188, 105);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 20);
            this.YearBox.TabIndex = 9;
            // 
            // RentPricePerDayBox
            // 
            this.RentPricePerDayBox.Location = new System.Drawing.Point(188, 162);
            this.RentPricePerDayBox.Name = "RentPricePerDayBox";
            this.RentPricePerDayBox.Size = new System.Drawing.Size(121, 20);
            this.RentPricePerDayBox.TabIndex = 11;
            // 
            // GearUnitTypeBox
            // 
            this.GearUnitTypeBox.FormattingEnabled = true;
            this.GearUnitTypeBox.Location = new System.Drawing.Point(188, 134);
            this.GearUnitTypeBox.Name = "GearUnitTypeBox";
            this.GearUnitTypeBox.Size = new System.Drawing.Size(121, 21);
            this.GearUnitTypeBox.TabIndex = 12;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(12, 196);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 13;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // carEntityBindingSource
            // 
            this.carEntityBindingSource.DataSource = typeof(AutoRent.Database.CarEntity);
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 242);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.GearUnitTypeBox);
            this.Controls.Add(this.RentPricePerDayBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.VendorBox);
            this.Controls.Add(this.RegNumberBox);
            this.Controls.Add(this.RentPricePerDay);
            this.Controls.Add(this.GearUnitType);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Vendor);
            this.Controls.Add(this.RegNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCar";
            ((System.ComponentModel.ISupportInitialize)(this.carEntityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegNumber;
        private System.Windows.Forms.Label Vendor;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label GearUnitType;
        private System.Windows.Forms.Label RentPricePerDay;
        private System.Windows.Forms.TextBox RegNumberBox;
        private System.Windows.Forms.TextBox VendorBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox RentPricePerDayBox;
        private System.Windows.Forms.ComboBox GearUnitTypeBox;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.BindingSource carEntityBindingSource;
    }
}