﻿namespace AutoRent.Forms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PersonalNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearUnitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cars = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearUnitTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPricePerDayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RentedCarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableCars
            // 
            this.AvailableCars.AutoSize = true;
            this.AvailableCars.Location = new System.Drawing.Point(15, 297);
            this.AvailableCars.Name = "AvailableCars";
            this.AvailableCars.Size = new System.Drawing.Size(74, 13);
            this.AvailableCars.TabIndex = 19;
            this.AvailableCars.Text = "Available Cars";
            // 
            // CountOfDays
            // 
            this.CountOfDays.AutoSize = true;
            this.CountOfDays.Location = new System.Drawing.Point(466, 313);
            this.CountOfDays.Name = "CountOfDays";
            this.CountOfDays.Size = new System.Drawing.Size(76, 13);
            this.CountOfDays.TabIndex = 20;
            this.CountOfDays.Text = "Count Of Days";
            // 
            // CountOfDaysTextBox
            // 
            this.CountOfDaysTextBox.Location = new System.Drawing.Point(469, 330);
            this.CountOfDaysTextBox.Name = "CountOfDaysTextBox";
            this.CountOfDaysTextBox.Size = new System.Drawing.Size(73, 20);
            this.CountOfDaysTextBox.TabIndex = 21;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(469, 356);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(73, 23);
            this.ButtonCalculate.TabIndex = 22;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Location = new System.Drawing.Point(469, 385);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(73, 20);
            this.PriceTextBox.TabIndex = 23;
            this.PriceTextBox.Text = "Price";
            // 
            // ButtonRent
            // 
            this.ButtonRent.Location = new System.Drawing.Point(469, 515);
            this.ButtonRent.Name = "ButtonRent";
            this.ButtonRent.Size = new System.Drawing.Size(73, 23);
            this.ButtonRent.TabIndex = 24;
            this.ButtonRent.Text = "Rent";
            this.ButtonRent.UseVisualStyleBackColor = true;
            // 
            // RentedCars
            // 
            this.RentedCars.AutoSize = true;
            this.RentedCars.Location = new System.Drawing.Point(545, 297);
            this.RentedCars.Name = "RentedCars";
            this.RentedCars.Size = new System.Drawing.Size(66, 13);
            this.RentedCars.TabIndex = 26;
            this.RentedCars.Text = "Rented Cars";
            // 
            // RentedCarGridView
            // 
            this.RentedCarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentedCarGridView.Location = new System.Drawing.Point(548, 313);
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
            this.AvailableCarGridView.Location = new System.Drawing.Point(15, 313);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.iDDataGridViewTextBoxColumn,
            this.regNumberDataGridViewTextBoxColumn1,
            this.vendorDataGridViewTextBoxColumn1,
            this.modelDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.gearUnitTypeDataGridViewTextBoxColumn1,
            this.rentPricePerDayDataGridViewTextBoxColumn1,
            this.clientIDDataGridViewTextBoxColumn,
            this.currentClientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.Cars;
            this.dataGridView1.Location = new System.Drawing.Point(15, 313);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vendor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vendor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Available Cars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Count Of Days";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(469, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 23;
            this.textBox2.Text = "Price";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Rent";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(548, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 225);
            this.dataGridView2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rented Cars";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.FirstNameBox);
            this.groupBox2.Controls.Add(this.LastNameBox);
            this.groupBox2.Controls.Add(this.PersonalNumberBox);
            this.groupBox2.Controls.Add(this.PhoneNumberBox);
            this.groupBox2.Controls.Add(this.AddressBox);
            this.groupBox2.Controls.Add(this.EmailBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 282);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Personal Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Address";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Enabled = false;
            this.FirstNameBox.Location = new System.Drawing.Point(108, 22);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(319, 20);
            this.FirstNameBox.TabIndex = 12;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(108, 58);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(319, 20);
            this.LastNameBox.TabIndex = 13;
            // 
            // PersonalNumberBox
            // 
            this.PersonalNumberBox.Enabled = false;
            this.PersonalNumberBox.Location = new System.Drawing.Point(108, 95);
            this.PersonalNumberBox.Name = "PersonalNumberBox";
            this.PersonalNumberBox.Size = new System.Drawing.Size(319, 20);
            this.PersonalNumberBox.TabIndex = 14;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Enabled = false;
            this.PhoneNumberBox.Location = new System.Drawing.Point(108, 132);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(319, 20);
            this.PhoneNumberBox.TabIndex = 15;
            // 
            // AddressBox
            // 
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(108, 203);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddressBox.Size = new System.Drawing.Size(319, 63);
            this.AddressBox.TabIndex = 17;
            // 
            // EmailBox
            // 
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(108, 166);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(319, 20);
            this.EmailBox.TabIndex = 16;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regNumberDataGridViewTextBoxColumn1
            // 
            this.regNumberDataGridViewTextBoxColumn1.DataPropertyName = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn1.HeaderText = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn1.Name = "regNumberDataGridViewTextBoxColumn1";
            this.regNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vendorDataGridViewTextBoxColumn1
            // 
            this.vendorDataGridViewTextBoxColumn1.DataPropertyName = "Vendor";
            this.vendorDataGridViewTextBoxColumn1.HeaderText = "Vendor";
            this.vendorDataGridViewTextBoxColumn1.Name = "vendorDataGridViewTextBoxColumn1";
            this.vendorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn1
            // 
            this.modelDataGridViewTextBoxColumn1.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn1.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn1.Name = "modelDataGridViewTextBoxColumn1";
            this.modelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gearUnitTypeDataGridViewTextBoxColumn1
            // 
            this.gearUnitTypeDataGridViewTextBoxColumn1.DataPropertyName = "GearUnitType";
            this.gearUnitTypeDataGridViewTextBoxColumn1.HeaderText = "GearUnitType";
            this.gearUnitTypeDataGridViewTextBoxColumn1.Name = "gearUnitTypeDataGridViewTextBoxColumn1";
            this.gearUnitTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // rentPricePerDayDataGridViewTextBoxColumn1
            // 
            this.rentPricePerDayDataGridViewTextBoxColumn1.DataPropertyName = "RentPricePerDay";
            this.rentPricePerDayDataGridViewTextBoxColumn1.HeaderText = "RentPricePerDay";
            this.rentPricePerDayDataGridViewTextBoxColumn1.Name = "rentPricePerDayDataGridViewTextBoxColumn1";
            this.rentPricePerDayDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentClientDataGridViewTextBoxColumn
            // 
            this.currentClientDataGridViewTextBoxColumn.DataPropertyName = "CurrentClient";
            this.currentClientDataGridViewTextBoxColumn.HeaderText = "CurrentClient";
            this.currentClientDataGridViewTextBoxColumn.Name = "currentClientDataGridViewTextBoxColumn";
            this.currentClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RentedCars);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RentedCarGridView);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ButtonRent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountOfDaysTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountOfDays);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AvailableCars);
            this.Controls.Add(this.AvailableCarGridView);
            this.Name = "RentCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Car";
            ((System.ComponentModel.ISupportInitialize)(this.RentedCarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PersonalNumberBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearUnitTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPricePerDayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentClientDataGridViewTextBoxColumn;
    }
}