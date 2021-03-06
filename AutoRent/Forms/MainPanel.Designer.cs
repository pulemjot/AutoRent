﻿using System.Windows.Forms;

namespace AutoRent.Forms
{
    partial class MainPanel
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
            this.ViewClients = new System.Windows.Forms.Button();
            this.ViewCars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewClients
            // 
            this.ViewClients.Location = new System.Drawing.Point(12, 12);
            this.ViewClients.Name = "ViewClients";
            this.ViewClients.Size = new System.Drawing.Size(260, 70);
            this.ViewClients.TabIndex = 0;
            this.ViewClients.Text = "View Clients";
            this.ViewClients.UseVisualStyleBackColor = true;
            this.ViewClients.Click += new System.EventHandler(this.ViewClients_Click);
            // 
            // ViewCars
            // 
            this.ViewCars.Location = new System.Drawing.Point(13, 88);
            this.ViewCars.Name = "ViewCars";
            this.ViewCars.Size = new System.Drawing.Size(260, 70);
            this.ViewCars.TabIndex = 1;
            this.ViewCars.Text = "View Cars";
            this.ViewCars.UseVisualStyleBackColor = true;
            this.ViewCars.Click += new System.EventHandler(this.ViewCars_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.ViewCars);
            this.Controls.Add(this.ViewClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Panel";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewClients;
        private System.Windows.Forms.Button ViewCars;
    }
}