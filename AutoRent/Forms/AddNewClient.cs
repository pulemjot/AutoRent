﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    partial class AddNewClient : Form {
        readonly DbManager _mgr = new DbManager();
        readonly ClientEntity _client = new ClientEntity();
        public AddNewClient() {
            InitializeComponent();
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
        }

        public ClientEntity AddedClient { get; private set; }

        void ButtonSave_Click(object sender, EventArgs e) {
            var ctx = new ValidationContext(_client);
            IList<ValidationResult> errors = new List<ValidationResult>();
            var sb = new StringBuilder();
            if (!Validator.TryValidateObject(_client, ctx, errors, true)) {
                foreach (ValidationResult result in errors) {
                    sb.AppendLine(result.ErrorMessage);
                }
                MessageBox.Show(sb.ToString(), "Form Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                _mgr.AddClient(_client);
                AddedClient = _client;
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Save client error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
