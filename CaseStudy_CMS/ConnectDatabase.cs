using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CaseStudy_CMS
{
    class ConnectDatabase
    {
        private string connectionString;
        public MySqlConnection sqlConnection;

        public void connectSql()
        {
            try
            {
                connectionString = "datasource=127.0.0.1;port=3308;username=root;pwd=;database=dbcms";
                sqlConnection = new MySqlConnection(connectionString);
            }
            catch
            {
                 MyMessageBox.ShowMessage("Something went wrong while connecting to database", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
