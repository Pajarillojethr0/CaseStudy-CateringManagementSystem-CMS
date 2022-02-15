using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CaseStudy_CMS
{
    class SQLQueries
    {
        string query;
        public int rowCount;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dataTable;
        
        // this method is for the Login Form
        public string Login(string username, string password)
        {
            query = "SELECT * FROM tblaccounts WHERE Username = '" + username + "' AND Password = '" + password + "' ";
            
            //this code is for connection
            ConnectDatabase conDb = new ConnectDatabase();
            conDb.connectSql();

            using (sqlDataAdapter = new MySqlDataAdapter(query, conDb.sqlConnection))
            {
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count <= 0)
                {
                    return "Failed";
                }
                else
                {
                   return "Success";
                }
            }
        }

        public string checkEvent(string date)
        {
            query = "SELECT * FROM tbl_schedule WHERE Event_Date = '" + date + "'";

            //the path to connect
            ConnectDatabase conDb = new ConnectDatabase();
            conDb.connectSql();
            //open connection
            conDb.sqlConnection.Open();

            sqlCommand = new MySqlCommand(query, conDb.sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                UC_Dates userDates = new UC_Dates();
                string eventName = sqlDataReader["Name_of_Event"].ToString();

                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);

                rowCount = dataTable.Rows.Count;
                rowCount++;
                sqlDataReader.Dispose();
                conDb.sqlConnection.Close();
                return eventName;
            }
            else
            {
                sqlDataReader.Dispose();
                conDb.sqlConnection.Close();
                return null;
            }

        }

        public void InsertEventDetails(string nameofEvent, string noofGuest, string fName, string lName, string contact, string date)
        {
            ConnectDatabase conDb = new ConnectDatabase();
            conDb.connectSql();
            query = "INSERT INTO tbl_schedule(Name_of_Event, No_of_Guest, Firstname, Lastname, Contact, Event_Date)" +
                    "VALUES('" + nameofEvent + "', '" + noofGuest + "', '" + fName + "', '"+ lName +"', '"+ contact +"', '"+ date +"')";
            sqlCommand = new MySqlCommand(query, conDb.sqlConnection);

            try
            {
                conDb.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MyMessageBox.ShowMessage("Item Added Successfully", "Insert Task", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                conDb.sqlConnection.Close();
            }
            catch (MySqlException e)
            {
                MyMessageBox.ShowMessage("Something went wrong", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }

        }
    }
}
