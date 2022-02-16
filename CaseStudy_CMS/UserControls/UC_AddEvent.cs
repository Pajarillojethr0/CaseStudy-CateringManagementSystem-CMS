using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace CaseStudy_CMS
{
    public partial class UC_AddEvent : UserControl
    {
      
        public UC_AddEvent()
        {
            InitializeComponent();
            
        }
        //get date today
        static DateTime currentDate = DateTime.Now;
        public static int month = currentDate.Month;
        public static int year = currentDate.Year;

        private void UC_AddEvent_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            //set label name to the current month and year
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_Month.Text = monthname + " " + year;
            
            //the first date of the month this is important to position the usercontrol
            DateTime firstDateOfTheMonth = new DateTime(year, month,1);

            //count the number of days in a month this is for how many usercontrol you need to add
            int countMonthDates = DateTime.DaysInMonth(year, month);

            //get what day is the firstdate of the month ---> the purpose of "d" to convert the value to 1-7
            int positionOfFirstDayOfTheMonth = Convert.ToInt32(firstDateOfTheMonth.DayOfWeek.ToString("d"));
          
            //add front blank dates
            for(int i = 1; i != positionOfFirstDayOfTheMonth+1; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                flp_Calendar.Controls.Add(ucBlank);
            }
            //add dates
            for(int i = 1; i <= countMonthDates; i++)
            {
                UC_Dates ucDays = new UC_Dates();
                flp_Calendar.Controls.Add(ucDays);

                ucDays.Dates(i);
            }
            //blankDates variable is for the blank dates at the end of the month
            int blankDates = positionOfFirstDayOfTheMonth + countMonthDates;
            //add end blank dates
            for(int i = 0; i < 42 - blankDates; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                flp_Calendar.Controls.Add(ucBlank);
            }
        }

        private void NextMonth()
        {
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;
            }
            
            //clear flow layout
            flp_Calendar.Controls.Clear();

            //set label name to the current month and year
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_Month.Text = monthname + " " + year;

            //the first date of the month this is important to position the usercontrol
            DateTime firstDateOfTheMonth = new DateTime(year, month, 1);

            //count the number of days in a month this is for how many usercontrol you need to add
            int countMonthDates = DateTime.DaysInMonth(year, month);

            //get what day is the firstdate of the month ---> the purpose of "d" to convert the value to 1-7
            int positionOfFirstDayOfTheMonth = Convert.ToInt32(firstDateOfTheMonth.DayOfWeek.ToString("d"));

            //add front blank dates
            for (int i = 1; i != positionOfFirstDayOfTheMonth + 1; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                flp_Calendar.Controls.Add(ucBlank);
            }
            //add dates
            for (int i = 1; i <= countMonthDates; i++)
            {
                UC_Dates ucDays = new UC_Dates();
                flp_Calendar.Controls.Add(ucDays);

                ucDays.Dates(i);
            }
            //blankDates variable is for the blank dates at the end of the month
            int blankDates = positionOfFirstDayOfTheMonth + countMonthDates;
            //add end blank dates
            for (int i = 0; i < 42 - blankDates; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                flp_Calendar.Controls.Add(ucBlank);
            }
        }

        private void PreviousMonth()
        {
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }

            //Empty flow layout
            flp_Calendar.Controls.Clear();

            //set label name to the current month and year
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_Month.Text = monthname + " " + year;

            //the first date of the month this is important to position the usercontrol
            DateTime firstDateOfTheMonth = new DateTime(year, month, 1);

            //count the number of days in a month this is for how many usercontrol you need to add
            int countMonthDates = DateTime.DaysInMonth(year, month);

            //get what day is the firstdate of the month ---> the purpose of "d" to convert the value to 1-7
            int positionOfFirstDayOfTheMonth = Convert.ToInt32(firstDateOfTheMonth.DayOfWeek.ToString("d"));

            //add front blank dates
            for (int i = 1; i != positionOfFirstDayOfTheMonth + 1; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                flp_Calendar.Controls.Add(ucBlank);
            }
            //add dates
            for (int i = 1; i <= countMonthDates; i++)
            {
                UC_Dates ucDays = new UC_Dates();
                flp_Calendar.Controls.Add(ucDays);

                ucDays.Dates(i);
            }
            //blankDates variable is for the blank dates at the end of the month
            int blankDates = positionOfFirstDayOfTheMonth + countMonthDates;
            //add end blank dates
            for (int i = 0; i < 42 - blankDates; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                flp_Calendar.Controls.Add(ucBlank);
            }
        }

        private void btn_Previous_MouseEnter(object sender, EventArgs e)
        {
            btn_Previous.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            PreviousMonth();
        }

        private void btn_Previous_MouseLeave(object sender, EventArgs e)
        {
            btn_Previous.BackColor = Color.DimGray;
        }

        private void btn_Next_MouseEnter(object sender, EventArgs e)
        {
            btn_Next.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void btn_Next_MouseLeave(object sender, EventArgs e)
        {
            btn_Next.BackColor = Color.DimGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
