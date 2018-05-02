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
            var configuration = new Configuration();
            var dbMigrator = new DbMigrator(configuration);
            dbMigrator.Update();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
