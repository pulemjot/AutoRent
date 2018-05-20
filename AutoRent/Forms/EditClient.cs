using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class EditClient : Form
    {
        readonly DbManager _mgr = new DbManager();
        readonly ClientEntity _client;

        public EditClient(ClientEntity client) {
            InitializeComponent();
            _client = client;
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
        }

        private void ButtonSave_Click(Object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            try {
                _mgr.EditClient(_client);
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Save client error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            var ctx = new ValidationContext(_client);
            IList<ValidationResult> errors = new List<ValidationResult>();
            var sb = new StringBuilder();
            if (Validator.TryValidateObject(_client, ctx, errors, true))
            {
                return true;
            }

            foreach (ValidationResult result in errors)
            {
                sb.AppendLine(result.ErrorMessage);
            }

            MessageBox.Show(sb.ToString(), "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }
    }
}
