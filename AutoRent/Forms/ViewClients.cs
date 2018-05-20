using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    public partial class ViewClients : Form {
        readonly DbManager _mgr = new DbManager();
        public ViewClients() {
            InitializeComponent();
            RefreshClientTable();
        }

        void RefreshClientTable() {
            try {
                Clients.DataSource = _mgr.GetClients();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load Client List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void AddClient_Click(Object sender, EventArgs e) {
            var dlg = new AddClient();
            dlg.ShowDialog(this);
            if (dlg.AddedClient != null) {
                RefreshClientTable();
            }
        }

        void EditClient_Click(Object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = ClientGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (ClientEntity)rows[0].DataBoundItem;
            var dlg = new EditClient(car);
            dlg.ShowDialog(this);
            RefreshClientTable();
        }

        private void RefreshClientListButton_Click(Object sender, EventArgs e) {
            RefreshClientTable();
        }

        private void RentCar_Click(Object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = ClientGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var client = (ClientEntity)rows[0].DataBoundItem;
            var dlg = new RentCar(client);
            dlg.ShowDialog(this);
            RefreshClientTable();
        }

        private void ReturnCar_Click(Object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = ClientGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var client = (ClientEntity)rows[0].DataBoundItem;
            var dlg = new ReturnCar(client);
            dlg.ShowDialog(this);
            RefreshClientTable();
        }
    }
}
