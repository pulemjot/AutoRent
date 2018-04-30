using System;
using System.Windows.Forms;

namespace AutoRent.Forms {
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void ViewClients_Click(object sender, EventArgs e) {
            var dlg = new ViewClients();
            dlg.Show(this);
        }

        private void ViewCars_Click(object sender, EventArgs e) {
            var dlg = new ViewCars();
            dlg.Show(this);
        }
    }
}
