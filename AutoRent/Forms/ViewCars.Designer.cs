namespace AutoRent.Forms {
    partial class ViewCars
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
            this.AddCar = new System.Windows.Forms.Button();
            this.EditCar = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.vendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearUnitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentPricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cars = new System.Windows.Forms.BindingSource(this.components);
            this.RefreshCarListButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(93, 21);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(75, 23);
            this.AddCar.TabIndex = 0;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = true;
            this.AddCar.Click += new System.EventHandler(this.AddCar_Click);
            // 
            // EditCar
            // 
            this.EditCar.Location = new System.Drawing.Point(174, 21);
            this.EditCar.Name = "EditCar";
            this.EditCar.Size = new System.Drawing.Size(75, 23);
            this.EditCar.TabIndex = 1;
            this.EditCar.Text = "Edit Car";
            this.EditCar.UseVisualStyleBackColor = true;
            this.EditCar.Click += new System.EventHandler(this.EditCar_Click);
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(255, 21);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(75, 23);
            this.DeleteCar.TabIndex = 2;
            this.DeleteCar.Text = "Delete Car";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.RemoveCar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RefreshCarListButton);
            this.panel1.Controls.Add(this.AddCar);
            this.panel1.Controls.Add(this.EditCar);
            this.panel1.Controls.Add(this.DeleteCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 60);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CarGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 275);
            this.panel2.TabIndex = 5;
            // 
            // CarGridView
            // 
            this.CarGridView.AllowUserToAddRows = false;
            this.CarGridView.AllowUserToDeleteRows = false;
            this.CarGridView.AllowUserToOrderColumns = true;
            this.CarGridView.AutoGenerateColumns = false;
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.regNumberDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.gearUnitTypeDataGridViewTextBoxColumn,
            this.rentPricePerDayDataGridViewTextBoxColumn});
            this.CarGridView.DataSource = this.Cars;
            this.CarGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarGridView.Location = new System.Drawing.Point(0, 0);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CarGridView.Size = new System.Drawing.Size(669, 275);
            this.CarGridView.TabIndex = 0;
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
            // RefreshCarListButton
            // 
            this.RefreshCarListButton.Location = new System.Drawing.Point(12, 21);
            this.RefreshCarListButton.Name = "RefreshCarListButton";
            this.RefreshCarListButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshCarListButton.TabIndex = 3;
            this.RefreshCarListButton.Text = "Refresh";
            this.RefreshCarListButton.UseVisualStyleBackColor = true;
            this.RefreshCarListButton.Click += new System.EventHandler(this.RefreshCarListButton_Click);
            // 
            // ViewCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "ViewCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cars";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button EditCar;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.BindingSource Cars;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearUnitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentPricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RefreshCarListButton;
    }
}