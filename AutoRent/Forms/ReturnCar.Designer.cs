﻿namespace AutoRent.Forms
{
    partial class ReturnCar
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
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.RentedCars = new System.Windows.Forms.Label();
            this.RentedCarGridView = new System.Windows.Forms.DataGridView();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PersonalNumberBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PersonalNumber = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentedCarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.Location = new System.Drawing.Point(660, 233);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(73, 23);
            this.ButtonReturn.TabIndex = 43;
            this.ButtonReturn.TabStop = false;
            this.ButtonReturn.Text = "Return";
            this.ButtonReturn.UseVisualStyleBackColor = true;
            // 
            // RentedCars
            // 
            this.RentedCars.AutoSize = true;
            this.RentedCars.Location = new System.Drawing.Point(369, 15);
            this.RentedCars.Name = "RentedCars";
            this.RentedCars.Size = new System.Drawing.Size(66, 13);
            this.RentedCars.TabIndex = 38;
            this.RentedCars.Text = "Rented Cars";
            // 
            // RentedCarGridView
            // 
            this.RentedCarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedCarGridView.Location = new System.Drawing.Point(372, 31);
            this.RentedCarGridView.Name = "RentedCarGridView";
            this.RentedCarGridView.Size = new System.Drawing.Size(270, 225);
            this.RentedCarGridView.TabIndex = 37;
            // 
            // AddressBox
            // 
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(101, 193);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressBox.Size = new System.Drawing.Size(240, 63);
            this.AddressBox.TabIndex = 36;
            // 
            // EmailBox
            // 
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(101, 156);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(240, 20);
            this.EmailBox.TabIndex = 35;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Enabled = false;
            this.PhoneNumberBox.Location = new System.Drawing.Point(101, 122);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(240, 20);
            this.PhoneNumberBox.TabIndex = 34;
            // 
            // PersonalNumberBox
            // 
            this.PersonalNumberBox.Enabled = false;
            this.PersonalNumberBox.Location = new System.Drawing.Point(101, 85);
            this.PersonalNumberBox.Name = "PersonalNumberBox";
            this.PersonalNumberBox.Size = new System.Drawing.Size(240, 20);
            this.PersonalNumberBox.TabIndex = 33;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(101, 48);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(240, 20);
            this.LastNameBox.TabIndex = 32;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Enabled = false;
            this.FirstNameBox.Location = new System.Drawing.Point(101, 12);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(240, 20);
            this.FirstNameBox.TabIndex = 31;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(7, 196);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 30;
            this.Address.Text = "Address";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(7, 159);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 29;
            this.Email.Text = "Email";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(7, 125);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber.TabIndex = 28;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // PersonalNumber
            // 
            this.PersonalNumber.AutoSize = true;
            this.PersonalNumber.Location = new System.Drawing.Point(7, 88);
            this.PersonalNumber.Name = "PersonalNumber";
            this.PersonalNumber.Size = new System.Drawing.Size(88, 13);
            this.PersonalNumber.TabIndex = 27;
            this.PersonalNumber.Text = "Personal Number";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(7, 51);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 26;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(7, 15);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 25;
            this.FirstName.Text = "First Name";
            // 
            // ReturnCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 270);
            this.Controls.Add(this.ButtonReturn);
            this.Controls.Add(this.RentedCars);
            this.Controls.Add(this.RentedCarGridView);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.PersonalNumberBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.PersonalNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "ReturnCar";
            this.Text = "Return Car";
            ((System.ComponentModel.ISupportInitialize)(this.RentedCarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Label RentedCars;
        private System.Windows.Forms.DataGridView RentedCarGridView;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox PersonalNumberBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label PersonalNumber;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
    }
}