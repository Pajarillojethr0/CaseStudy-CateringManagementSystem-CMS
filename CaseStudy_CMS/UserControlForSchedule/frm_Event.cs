using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CaseStudy_CMS
{
    public partial class frm_Event : Form
    {
        public string date;
        public string fullDate;
        frm_EventDetails eventDetails;

        public frm_Event()
        {
            InitializeComponent();
        }
        
        private void frm_Event_Load(object sender, EventArgs e)
        {
        }

        public void addUserControl(UserControl UC)
        {
            UC.BackColor = Color.White;
            flp_EventContainer.Controls.Add(UC);
        }

        public void EventList(string date)
        {
            // this block of code is to add the user control in the flowlayout
            string query = "SELECT ID, Name_of_Event FROM tbl_schedule WHERE Event_Date = '" + date + "'";
            
            ConnectDatabase conDb = new ConnectDatabase();
            conDb.connectSql();
            //open connection
            conDb.sqlConnection.Open();
            MySqlCommand sqlCommand;

            MySqlDataReader sqlDataReader;
            sqlCommand = new MySqlCommand(query, conDb.sqlConnection);
            
            sqlDataReader = sqlCommand.ExecuteReader();

            ArrayList alEvent = new ArrayList();
            ArrayList alID = new ArrayList();

            while (sqlDataReader.Read())
            {
                alEvent.Add(sqlDataReader["Name_of_Event"].ToString());
                alID.Add(sqlDataReader["ID"].ToString());
            }
           
            
            for(int i = 0; i < alEvent.Count; i++)
            {
                UC_Event userEvent = new UC_Event();
                userEvent.lbl_EventName.Text = alEvent[i].ToString();
                userEvent.eventID = alID[i].ToString();
                addUserControl(userEvent);
            }

            sqlDataReader.Close();
            conDb.sqlConnection.Close();
        }

        private void btn_NewEvent_Click(object sender, EventArgs e)
        {
            eventDetails = new frm_EventDetails();
            eventDetails.lbl_EventDate.Text = fullDate;
            eventDetails.ShowDialog();
            this.Close();
        }
        
    }
}