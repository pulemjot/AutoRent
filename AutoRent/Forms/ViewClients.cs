using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    public partial class ViewClients : Form
    {
        readonly DbManager _mgr = new DbManager();
        public ViewClients()
        {
            InitializeComponent();
            Clients.DataSource = _mgr.GetClients();
        }

        private void AddClient_Click(object sender, System.EventArgs e)
        {
            var dlg = new AddNewClient();
            dlg.ShowDialog(this);
        }

        private void EditClient_Click(object sender, System.EventArgs e)
        {
            var dlg = new EditClient();
            dlg.ShowDialog(this);
        }
    }
}
