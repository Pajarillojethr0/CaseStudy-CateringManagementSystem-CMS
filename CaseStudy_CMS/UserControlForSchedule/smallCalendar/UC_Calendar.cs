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

namespace CaseStudy_CMS
{
    public partial class UC_Calendar : UserControl
    {
        public UC_Calendar()
        {
            InitializeComponent();
        }

        //get date today
        static DateTime currentDate = DateTime.Now;
        public static int month = currentDate.Month;
        public static int year = currentDate.Year;

        private void DisplayDays()
        {
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
                UC_SmallBlank ucSBlank = new UC_SmallBlank();
                flp_Calendar.Controls.Add(ucSBlank);
            }
            //add dates
            for (int i = 1; i <= countMonthDates; i++)
            {
                UC_SmallDates ucSDays = new UC_SmallDates();
                flp_Calendar.Controls.Add(ucSDays);

                ucSDays.Dates(i);
            }
            //blankDates variable is for the blank dates at the end of the month
            int blankDates = positionOfFirstDayOfTheMonth + countMonthDates;
            //add end blank dates
            for (int i = 0; i < 42 - blankDates; i++)
            {
                UC_SmallBlank ucSBlank = new UC_SmallBlank();
                flp_Calendar.Controls.Add(ucSBlank);
            }
        }

        private void UC_Calendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
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
                UC_SmallBlank ucSBlank = new UC_SmallBlank();
                flp_Calendar.Controls.Add(ucSBlank);
            }
            //add dates
            for (int i = 1; i <= countMonthDates; i++)
            {
                UC_SmallDates ucSDays = new UC_SmallDates();
                flp_Calendar.Controls.Add(ucSDays);

                ucSDays.Dates(i);
            }
            //blankDates variable is for the blank dates at the end of the month
            int blankDates = positionOfFirstDayOfTheMonth + countMonthDates;
            //add end blank dates
            for (int i = 0; i < 42 - blankDates; i++)
            {
                UC_SmallBlank ucSBlank = new UC_SmallBlank();
                flp_Calendar.Controls.Add(ucSBlank);
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
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
                UC_SmallBlank ucSBlank = new UC_SmallBlank();
                flp_Calendar.Controls.Add(ucSBlank);
            }
            //add dates
            for (int i = 1; i <= countMonthDates; i++)
            {
                UC_SmallDates ucSDays = new UC_SmallDates();
                flp_Calendar.Controls.Add(ucSDays);

                ucSDays.Dates(i);
            }
            //blankDates variable is for the blank dates at the end of the month
            int blankDates = positionOfFirstDayOfTheMonth + countMonthDates;
            //add end blank dates
            for (int i = 0; i < 42 - blankDates; i++)
            {
                UC_SmallBlank ucSBlank = new UC_SmallBlank();
                flp_Calendar.Controls.Add(ucSBlank);
            }
        }
    }
}
