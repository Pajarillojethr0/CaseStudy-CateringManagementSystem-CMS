using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CaseStudy_CMS
{
    public partial class UC_Dates : UserControl
    {
        frm_EventDetails eventDetails;
        string year = UC_AddEvent.year.ToString();
        string month = UC_AddEvent.month.ToString();
        //string dateMonth;// date for the month
        string lblLength;
        public string fullDate;//exact date yyyy-MM-dd

        public UC_Dates()
        {
            InitializeComponent();
        }
        
        public void Dates(int numdates)
        {
            lbl_day.Text = numdates.ToString();
            lblLength = lbl_day.Text;

            //add zero to the front of the month and day if it is single char
            if (lblLength.Length == 1)
            {
                lbl_day.Text = "0" + lbl_day.Text;
            }
            if (month.Length == 1)
            {
                month = $"0{month}";
            }
            fullDate = $"{year}-{month}-{lbl_day.Text}";//full Date yyyy/MM/dd
            
            SQLQueries queries = new SQLQueries();
            string eventName = queries.checkEvent(fullDate);//store return in eventName variable

            if (queries.rowCount >= 1)
            {
                lbl_EventCount.Text = queries.rowCount.ToString();
            }
        }
            
        private void UC_Dates_Click(object sender, EventArgs e)
        {
            eventDetails = new frm_EventDetails();
            frm_Event fEvent = new frm_Event();
            SQLQueries queries = new SQLQueries();
            
            fEvent.fullDate = fullDate;
            fEvent.EventList(fullDate);
            
            //to refresh if there is new add event 
            queries.checkEvent(fullDate);
            if (queries.rowCount >= 1)
            {
                lbl_EventCount.Text = queries.rowCount.ToString();
                fEvent.ShowDialog();
            }
            else
            {
                frm_EventDetails eventDetails = new frm_EventDetails();
                eventDetails.lbl_EventDate.Text = fullDate;
                eventDetails.ShowDialog();
            }
            //send current date to the eventDetails form

            //eventDetails.ShowDialog();
        }
        
        private void reload()
        {
            SQLQueries queries = new SQLQueries();
            queries.checkEvent(fullDate);
        }
        private void UC_Dates_Load(object sender, EventArgs e)
        {
           
        }
        
        
    }
}
