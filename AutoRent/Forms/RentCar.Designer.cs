namespace AutoRent.Forms
{
    partial class RentCar
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
            this.Address = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.PersonalNumber = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.PersonalNumberBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.AvailableCars = new System.Windows.Forms.Label();
            this.CountOfDays = new System.Windows.Forms.Label();
            this.CountOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ButtonRent = new System.Windows.Forms.Button();
            this.RentedCars = new System.Windows.Forms.Label();
            this.RentedCarGridView = new System.Windows.Forms.DataGridView();
            this.AvailableCarGridView = new System.Windows.Forms.DataGridView();
            this.vendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearUnitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cars = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RentedCarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(12, 190);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 11;
            this.Address.Text = "Address";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 153);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(12, 119);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber.TabIndex = 9;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // PersonalNumber
            // 
            this.PersonalNumber.AutoSize = true;
            this.PersonalNumber.Location = new System.Drawing.Point(12, 82);
            this.PersonalNumber.Name = "PersonalNumber";
            this.PersonalNumber.Size = new System.Drawing.Size(88, 13);
            this.PersonalNumber.TabIndex = 8;
            this.PersonalNumber.Text = "Personal Number";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(12, 45);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 7;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(12, 9);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "First Name";
            // 
            // AddressBox
            // 
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(106, 187);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressBox.Size = new System.Drawing.Size(240, 63);
            this.AddressBox.TabIndex = 17;
            // 
            // EmailBox
            // 
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(106, 150);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(240, 20);
            this.EmailBox.TabIndex = 16;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Enabled = false;
            this.PhoneNumberBox.Location = new System.Drawing.Point(106, 116);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(240, 20);
            this.PhoneNumberBox.TabIndex = 15;
            // 
            // PersonalNumberBox
            // 
            this.PersonalNumberBox.Enabled = false;
            this.PersonalNumberBox.Location = new System.Drawing.Point(106, 79);
            this.PersonalNumberBox.Name = "PersonalNumberBox";
            this.PersonalNumberBox.Size = new System.Drawing.Size(240, 20);
            this.PersonalNumberBox.TabIndex = 14;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(106, 42);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(240, 20);
            this.LastNameBox.TabIndex = 13;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Enabled = false;
            this.FirstNameBox.Location = new System.Drawing.Point(106, 6);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(240, 20);
            this.FirstNameBox.TabIndex = 12;
            // 
            // AvailableCars
            // 
            this.AvailableCars.AutoSize = true;
            this.AvailableCars.Location = new System.Drawing.Point(352, 9);
            this.AvailableCars.Name = "AvailableCars";
            this.AvailableCars.Size = new System.Drawing.Size(74, 13);
            this.AvailableCars.TabIndex = 19;
            this.AvailableCars.Text = "Available Cars";
            // 
            // CountOfDays
            // 
            this.CountOfDays.AutoSize = true;
            this.CountOfDays.Location = new System.Drawing.Point(803, 25);
            this.CountOfDays.Name = "CountOfDays";
            this.CountOfDays.Size = new System.Drawing.Size(76, 13);
            this.CountOfDays.TabIndex = 20;
            this.CountOfDays.Text = "Count Of Days";
            // 
            // CountOfDaysTextBox
            // 
            this.CountOfDaysTextBox.Location = new System.Drawing.Point(806, 42);
            this.CountOfDaysTextBox.Name = "CountOfDaysTextBox";
            this.CountOfDaysTextBox.Size = new System.Drawing.Size(73, 20);
            this.CountOfDaysTextBox.TabIndex = 21;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(806, 68);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(73, 23);
            this.ButtonCalculate.TabIndex = 22;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Location = new System.Drawing.Point(806, 97);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(73, 20);
            this.PriceTextBox.TabIndex = 23;
            this.PriceTextBox.Text = "Price";
            // 
            // ButtonRent
            // 
            this.ButtonRent.Location = new System.Drawing.Point(806, 227);
            this.ButtonRent.Name = "ButtonRent";
            this.ButtonRent.Size = new System.Drawing.Size(73, 23);
            this.ButtonRent.TabIndex = 24;
            this.ButtonRent.Text = "Rent";
            this.ButtonRent.UseVisualStyleBackColor = true;
            // 
            // RentedCars
            // 
            this.RentedCars.AutoSize = true;
            this.RentedCars.Location = new System.Drawing.Point(882, 9);
            this.RentedCars.Name = "RentedCars";
            this.RentedCars.Size = new System.Drawing.Size(66, 13);
            this.RentedCars.TabIndex = 26;
            this.RentedCars.Text = "Rented Cars";
            // 
            // RentedCarGridView
            // 
            this.RentedCarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedCarGridView.Location = new System.Drawing.Point(885, 25);
            this.RentedCarGridView.Name = "RentedCarGridView";
            this.RentedCarGridView.Size = new System.Drawing.Size(350, 225);
            this.RentedCarGridView.TabIndex = 25;
            // 
            // AvailableCarGridView
            // 
            this.AvailableCarGridView.AllowUserToAddRows = false;
            this.AvailableCarGridView.AllowUserToDeleteRows = false;
            this.AvailableCarGridView.AllowUserToOrderColumns = true;
            this.AvailableCarGridView.AutoGenerateColumns = false;
            this.AvailableCarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableCarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.regNumberDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.gearUnitTypeDataGridViewTextBoxColumn,
            this.rentPricePerDayDataGridViewTextBoxColumn});
            this.AvailableCarGridView.DataSource = this.Cars;
            this.AvailableCarGridView.Location = new System.Drawing.Point(352, 25);
            this.AvailableCarGridView.MultiSelect = false;
            this.AvailableCarGridView.Name = "AvailableCarGridView";
            this.AvailableCarGridView.ReadOnly = true;
            this.AvailableCarGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableCarGridView.Size = new System.Drawing.Size(445, 225);
            this.AvailableCarGridView.TabIndex = 0;
            // 
            // vendorDataGridViewTextBoxColumn
            // 
            this.vendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor";
            this.vendorDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.vendorDataGridViewTextBoxColumn.Name = "vendorDataGridViewTextBoxColumn";
            this.vendorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regNumberDataGridViewTextBoxColumn
            // 
            this.regNumberDataGridViewTextBoxColumn.DataPropertyName = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.HeaderText = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.Name = "regNumberDataGridViewTextBoxColumn";
            this.regNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gearUnitTypeDataGridViewTextBoxColumn
            // 
            this.gearUnitTypeDataGridViewTextBoxColumn.DataPropertyName = "GearUnitType";
            this.gearUnitTypeDataGridViewTextBoxColumn.HeaderText = "GearUnitType";
            this.gearUnitTypeDataGridViewTextBoxColumn.Name = "gearUnitTypeDataGridViewTextBoxColumn";
            this.gearUnitTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentPricePerDayDataGridViewTextBoxColumn
            // 
            this.rentPricePerDayDataGridViewTextBoxColumn.DataPropertyName = "RentPricePerDay";
            this.rentPricePerDayDataGridViewTextBoxColumn.HeaderText = "RentPricePerDay";
            this.rentPricePerDayDataGridViewTextBoxColumn.Name = "rentPricePerDayDataGridViewTextBoxColumn";
            this.rentPricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cars
            // 
            this.Cars.DataSource = typeof(AutoRent.Database.CarEntity);
            // 
            // RentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 409);
            this.Controls.Add(this.RentedCars);
            this.Controls.Add(this.RentedCarGridView);
            this.Controls.Add(this.ButtonRent);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.CountOfDaysTextBox);
            this.Controls.Add(this.CountOfDays);
            this.Controls.Add(this.AvailableCars);
            this.Controls.Add(this.AvailableCarGridView);
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
            this.Name = "RentCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Car";
            ((System.ComponentModel.ISupportInitialize)(this.RentedCarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label PersonalNumber;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox PersonalNumberBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.BindingSource Cars;
        private System.Windows.Forms.DataGridView AvailableCarGridView;
        private System.Windows.Forms.Label AvailableCars;
        private System.Windows.Forms.Label CountOfDays;
        private System.Windows.Forms.TextBox CountOfDaysTextBox;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button ButtonRent;
        private System.Windows.Forms.Label RentedCars;
        private System.Windows.Forms.DataGridView RentedCarGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearUnitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPricePerDayDataGridViewTextBoxColumn;
    }
}