using AutoRent.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRent.Forms
{
    partial class RentCar : Form
    {
        readonly DbManager _mgr = new DbManager();
        readonly ClientEntity _client;
        public RentCar(ClientEntity client)
        {
            InitializeComponent();
            refreshCarList();
            _client = client;
            FirstNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.FirstName));
            LastNameBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.LastName));
            PersonalNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PersonalNumber));
            PhoneNumberBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.PhoneNumber));
            EmailBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Email));
            AddressBox.DataBindings.Add(nameof(TextBox.Text), _client, nameof(ClientEntity.Address));
        }
        void refreshCarList()
        {
            try
            {
                Cars.DataSource = _mgr.GetFreeCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Car List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
