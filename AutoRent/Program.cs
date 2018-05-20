using System;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using AutoRent.Forms;
using AutoRent.Migrations;

namespace AutoRent {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            try
            {
                var configuration = new Configuration();
                var dbMigrator = new DbMigrator(configuration);
                dbMigrator.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Database Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
