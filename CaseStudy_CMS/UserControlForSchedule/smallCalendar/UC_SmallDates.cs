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
    public partial class UC_SmallDates : UserControl
    {
        public bool calendarisShow;
        string year = UC_Calendar.year.ToString();
        string month = UC_Calendar.month.ToString();
        //string dateMonth;// date for the month
        string lblLength;
        public string smallFullDate;//exact date yyyy-MM-dd\

        public UC_SmallDates()
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
            smallFullDate = $"{year}-{month}-{lbl_day.Text}";//full Date yyyy/MM/dd

            highlightDate(smallFullDate);
            ShowCountEvent();
        }
            
        private void UC_Dates_Click(object sender, EventArgs e)
        {
            ShowCountEvent();
        }
        
        private void ShowCountEvent()
        {
            SQLQueries queries = new SQLQueries();
            string eventName = queries.checkEventSmall(smallFullDate);//store return in eventName variable

            if (queries.rowCount >= 1)
            {
                lbl_EventCount.Text = queries.rowCount.ToString();
            }
        }
        private void UC_Dates_Load(object sender, EventArgs e)
        {

        }

        private void highlightDate(string dateToday)
        {
            if (dateToday == DateTime.Now.ToString("yyyy-MM-dd"))
            {
                this.BackColor = Color.FromArgb(39, 54, 180);
            }
        }
    }
}
