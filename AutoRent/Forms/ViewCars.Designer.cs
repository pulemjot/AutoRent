namespace AutoRent.Forms
{
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
            this.AddCar = new System.Windows.Forms.Button();
            this.EditCar = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCar
            // 
            this.AddCar.Location = new System.Drawing.Point(12, 12);
            this.AddCar.Name = "AddCar";
            this.AddCar.Size = new System.Drawing.Size(75, 23);
            this.AddCar.TabIndex = 0;
            this.AddCar.Text = "Add Car";
            this.AddCar.UseVisualStyleBackColor = true;
            // 
            // EditCar
            // 
            this.EditCar.Location = new System.Drawing.Point(107, 12);
            this.EditCar.Name = "EditCar";
            this.EditCar.Size = new System.Drawing.Size(75, 23);
            this.EditCar.TabIndex = 1;
            this.EditCar.Text = "Edit Car";
            this.EditCar.UseVisualStyleBackColor = true;
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(202, 12);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(75, 23);
            this.DeleteCar.TabIndex = 2;
            this.DeleteCar.Text = "Delete Car";
            this.DeleteCar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 235);
            this.dataGridView1.TabIndex = 3;
            // 
            // ViewCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 288);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.EditCar);
            this.Controls.Add(this.AddCar);
            this.Name = "ViewCars";
            this.Text = "View Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCar;
        private System.Windows.Forms.Button EditCar;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}