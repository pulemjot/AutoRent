using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    public partial class ViewClients : Form {
        readonly DbManager _mgr = new DbManager();
        public ViewClients() {
            InitializeComponent();
            refreshClientList();
        }

        void refreshClientList() {
            try {
                Clients.DataSource = _mgr.GetClients();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load Client List Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void AddClient_Click(object sender, EventArgs e) {
            var dlg = new AddNewClient();
            dlg.ShowDialog(this);
            if (dlg.AddedClient != null) {
                Clients.Add(dlg.AddedClient);
            }
        }

        void EditClient_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = ClientGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var car = (ClientEntity)rows[0].DataBoundItem;
            var dlg = new EditClient(car);
            dlg.ShowDialog(this);
            refreshClientList();
        }

        private void RefreshClientListButton_Click(object sender, EventArgs e) {
            refreshClientList();
        }

        private void RentCar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = ClientGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var client = (ClientEntity)rows[0].DataBoundItem;
            var dlg = new RentCar(client);
            dlg.ShowDialog(this);
            refreshClientList();
        }

        private void ReturnCar_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection rows = ClientGridView.SelectedRows;
            if (rows.Count == 0) { return; }
            var client = (ClientEntity)rows[0].DataBoundItem;
            var dlg = new ReturnCar(client);
            dlg.ShowDialog(this);
            refreshClientList();
        }
    }
}
