using System.Windows.Forms;

namespace AutoRent.Forms
{
    partial class EditCar
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
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GearUnitTypeBox = new System.Windows.Forms.ComboBox();
            this.RentPricePerDayBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.VendorBox = new System.Windows.Forms.TextBox();
            this.RegNumberBox = new System.Windows.Forms.TextBox();
            this.RentPricePerDay = new System.Windows.Forms.Label();
            this.GearUnitType = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Vendor = new System.Windows.Forms.Label();
            this.RegNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(13, 197);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 26;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // GearUnitTypeBox
            // 
            this.GearUnitTypeBox.Enabled = false;
            this.GearUnitTypeBox.FormattingEnabled = true;
            this.GearUnitTypeBox.Location = new System.Drawing.Point(189, 135);
            this.GearUnitTypeBox.Name = "GearUnitTypeBox";
            this.GearUnitTypeBox.Size = new System.Drawing.Size(121, 21);
            this.GearUnitTypeBox.TabIndex = 25;
            // 
            // RentPricePerDayBox
            // 
            this.RentPricePerDayBox.Location = new System.Drawing.Point(189, 163);
            this.RentPricePerDayBox.Name = "RentPricePerDayBox";
            this.RentPricePerDayBox.Size = new System.Drawing.Size(121, 20);
            this.RentPricePerDayBox.TabIndex = 24;
            // 
            // YearBox
            // 
            this.YearBox.Enabled = false;
            this.YearBox.Location = new System.Drawing.Point(189, 106);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 20);
            this.YearBox.TabIndex = 23;
            // 
            // ModelBox
            // 
            this.ModelBox.Enabled = false;
            this.ModelBox.Location = new System.Drawing.Point(189, 76);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(121, 20);
            this.ModelBox.TabIndex = 22;
            // 
            // VendorBox
            // 
            this.VendorBox.Enabled = false;
            this.VendorBox.Location = new System.Drawing.Point(189, 45);
            this.VendorBox.Name = "VendorBox";
            this.VendorBox.Size = new System.Drawing.Size(121, 20);
            this.VendorBox.TabIndex = 21;
            // 
            // RegNumberBox
            // 
            this.RegNumberBox.Location = new System.Drawing.Point(189, 17);
            this.RegNumberBox.Name = "RegNumberBox";
            this.RegNumberBox.Size = new System.Drawing.Size(121, 20);
            this.RegNumberBox.TabIndex = 20;
            // 
            // RentPricePerDay
            // 
            this.RentPricePerDay.AutoSize = true;
            this.RentPricePerDay.Location = new System.Drawing.Point(13, 163);
            this.RentPricePerDay.Name = "RentPricePerDay";
            this.RentPricePerDay.Size = new System.Drawing.Size(98, 13);
            this.RentPricePerDay.TabIndex = 19;
            this.RentPricePerDay.Text = "Rent Price Per Day";
            // 
            // GearUnitType
            // 
            this.GearUnitType.AutoSize = true;
            this.GearUnitType.Location = new System.Drawing.Point(13, 135);
            this.GearUnitType.Name = "GearUnitType";
            this.GearUnitType.Size = new System.Drawing.Size(79, 13);
            this.GearUnitType.TabIndex = 18;
            this.GearUnitType.Text = "Gear Unit Type";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(13, 106);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 17;
            this.Year.Text = "Year";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(13, 76);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 16;
            this.Model.Text = "Model";
            // 
            // Vendor
            // 
            this.Vendor.AutoSize = true;
            this.Vendor.Location = new System.Drawing.Point(13, 45);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(41, 13);
            this.Vendor.TabIndex = 15;
            this.Vendor.Text = "Vendor";
            // 
            // RegNumber
            // 
            this.RegNumber.AutoSize = true;
            this.RegNumber.Location = new System.Drawing.Point(13, 17);
            this.RegNumber.Name = "RegNumber";
            this.RegNumber.Size = new System.Drawing.Size(103, 13);
            this.RegNumber.TabIndex = 14;
            this.RegNumber.Text = "Registration Number";
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 240);
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
            this.Name = "EditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ComboBox GearUnitTypeBox;
        private System.Windows.Forms.TextBox RentPricePerDayBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox VendorBox;
        private System.Windows.Forms.TextBox RegNumberBox;
        private System.Windows.Forms.Label RentPricePerDay;
        private System.Windows.Forms.Label GearUnitType;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Vendor;
        private System.Windows.Forms.Label RegNumber;
    }
}