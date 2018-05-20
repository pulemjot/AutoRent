namespace AutoRent.Forms {
    partial class ViewClients
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
            this.AddClient = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.RentCar = new System.Windows.Forms.Button();
            this.ReturnCar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshClientListButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeRentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(93, 22);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(75, 23);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(174, 22);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(75, 23);
            this.EditClient.TabIndex = 1;
            this.EditClient.Text = "Edit Client";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // RentCar
            // 
            this.RentCar.Location = new System.Drawing.Point(280, 22);
            this.RentCar.Name = "RentCar";
            this.RentCar.Size = new System.Drawing.Size(75, 23);
            this.RentCar.TabIndex = 2;
            this.RentCar.Text = "Rent Car";
            this.RentCar.UseVisualStyleBackColor = true;
            this.RentCar.Click += new System.EventHandler(this.RentCar_Click);
            // 
            // ReturnCar
            // 
            this.ReturnCar.Location = new System.Drawing.Point(361, 22);
            this.ReturnCar.Name = "ReturnCar";
            this.ReturnCar.Size = new System.Drawing.Size(75, 23);
            this.ReturnCar.TabIndex = 3;
            this.ReturnCar.Text = "Return Car";
            this.ReturnCar.UseVisualStyleBackColor = true;
            this.ReturnCar.Click += new System.EventHandler(this.ReturnCar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RefreshClientListButton);
            this.panel1.Controls.Add(this.AddClient);
            this.panel1.Controls.Add(this.ReturnCar);
            this.panel1.Controls.Add(this.EditClient);
            this.panel1.Controls.Add(this.RentCar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 63);
            this.panel1.TabIndex = 4;
            // 
            // RefreshClientListButton
            // 
            this.RefreshClientListButton.Location = new System.Drawing.Point(12, 22);
            this.RefreshClientListButton.Name = "RefreshClientListButton";
            this.RefreshClientListButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshClientListButton.TabIndex = 4;
            this.RefreshClientListButton.Text = "Refresh";
            this.RefreshClientListButton.UseVisualStyleBackColor = true;
            this.RefreshClientListButton.Click += new System.EventHandler(this.RefreshClientListButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClientGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 227);
            this.panel2.TabIndex = 5;
            // 
            // ClientGridView
            // 
            this.ClientGridView.AllowUserToAddRows = false;
            this.ClientGridView.AllowUserToDeleteRows = false;
            this.ClientGridView.AllowUserToOrderColumns = true;
            this.ClientGridView.AutoGenerateColumns = false;
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.activeRentCountDataGridViewTextBoxColumn});
            this.ClientGridView.DataSource = this.Clients;
            this.ClientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientGridView.Location = new System.Drawing.Point(0, 0);
            this.ClientGridView.MultiSelect = false;
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.ReadOnly = true;
            this.ClientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridView.Size = new System.Drawing.Size(571, 227);
            this.ClientGridView.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeRentCountDataGridViewTextBoxColumn
            // 
            this.activeRentCountDataGridViewTextBoxColumn.DataPropertyName = "ActiveRentCount";
            this.activeRentCountDataGridViewTextBoxColumn.HeaderText = "ActiveRentCount";
            this.activeRentCountDataGridViewTextBoxColumn.Name = "activeRentCountDataGridViewTextBoxColumn";
            this.activeRentCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Clients
            // 
            this.Clients.DataSource = typeof(AutoRent.Database.ClientEntity);
            // 
            // ViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "ViewClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewClients";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.Button RentCar;
        private System.Windows.Forms.Button ReturnCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.BindingSource Clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeRentCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button RefreshClientListButton;
    }
}