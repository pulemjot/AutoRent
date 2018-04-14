namespace AutoRent.Forms
{
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
            this.AddClient = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.RentCar = new System.Windows.Forms.Button();
            this.ReturnCar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(12, 12);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(75, 23);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(99, 12);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(75, 23);
            this.EditClient.TabIndex = 1;
            this.EditClient.Text = "Edit Client";
            this.EditClient.UseVisualStyleBackColor = true;
            // 
            // RentCar
            // 
            this.RentCar.Location = new System.Drawing.Point(186, 12);
            this.RentCar.Name = "RentCar";
            this.RentCar.Size = new System.Drawing.Size(75, 23);
            this.RentCar.TabIndex = 2;
            this.RentCar.Text = "Rent Car";
            this.RentCar.UseVisualStyleBackColor = true;
            // 
            // ReturnCar
            // 
            this.ReturnCar.Location = new System.Drawing.Point(273, 12);
            this.ReturnCar.Name = "ReturnCar";
            this.ReturnCar.Size = new System.Drawing.Size(75, 23);
            this.ReturnCar.TabIndex = 3;
            this.ReturnCar.Text = "Return Car";
            this.ReturnCar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 237);
            this.dataGridView1.TabIndex = 4;
            // 
            // ViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 290);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReturnCar);
            this.Controls.Add(this.RentCar);
            this.Controls.Add(this.EditClient);
            this.Controls.Add(this.AddClient);
            this.Name = "ViewClients";
            this.Text = "ViewClients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.Button RentCar;
        private System.Windows.Forms.Button ReturnCar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}