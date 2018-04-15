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
    }
}
