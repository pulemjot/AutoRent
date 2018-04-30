namespace AutoRent.Forms
{
    partial class AddNewClient
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.PersonalNumber = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PersonalNumberBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(12, 22);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(12, 58);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last Name";
            // 
            // PersonalNumber
            // 
            this.PersonalNumber.AutoSize = true;
            this.PersonalNumber.Location = new System.Drawing.Point(12, 95);
            this.PersonalNumber.Name = "PersonalNumber";
            this.PersonalNumber.Size = new System.Drawing.Size(88, 13);
            this.PersonalNumber.TabIndex = 2;
            this.PersonalNumber.Text = "Personal Number";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(12, 132);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumber.TabIndex = 3;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 166);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(12, 203);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(157, 19);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 6;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(157, 55);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameBox.TabIndex = 7;
            // 
            // PersonalNumberBox
            // 
            this.PersonalNumberBox.Location = new System.Drawing.Point(157, 92);
            this.PersonalNumberBox.Name = "PersonalNumberBox";
            this.PersonalNumberBox.Size = new System.Drawing.Size(100, 20);
            this.PersonalNumberBox.TabIndex = 8;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(157, 129);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumberBox.TabIndex = 9;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(157, 163);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 10;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(157, 200);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 20);
            this.AddressBox.TabIndex = 11;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(15, 240);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 281);
            this.Controls.Add(this.ButtonSave);
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
            this.MaximizeBox = false;
            this.Name = "AddNewClient";
            this.Text = "Add New Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label PersonalNumber;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PersonalNumberBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button ButtonSave;
    }
}