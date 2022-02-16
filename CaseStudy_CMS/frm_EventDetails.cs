using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_CMS
{
    public partial class frm_EventDetails : Form
    {
        public bool resizeDate;
        public string eventID;
        public frm_EventDetails()
        {
            InitializeComponent();
            UC_Dates userDates = new UC_Dates();
            lbl_EventDate.Text = userDates.fullDate;
        }
        
        private void btn_Venue_Click(object sender, EventArgs e)
        {
        }

        private void btn_Food_Click(object sender, EventArgs e)
        {
        }

        private void frm_EventDetails_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.MaskInputRejected += new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Invalid Input";
            toolTip1.Show("We're sorry, but only digits (0-9) are allowed in dates.", maskedTextBox1, maskedTextBox1.Location, 288);
        }

        private void lbl_EventDate_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string nameofEvent = tb_NameofEvent.Text;
            string noofGuest = nud_NoofGuest.Value.ToString();
            string firstName = tb_Firstname.Text;
            string lastName = tb_Lastname.Text;
            string contact = tb_Contact.Text;
            string date = lbl_EventDate.Text;


            SQLQueries queries = new SQLQueries();
            queries.InsertEventDetails(nameofEvent, noofGuest, firstName, lastName, contact,date);
            this.Close();
        }

        private void frm_EventDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            UC_AddEvent addEvent = new UC_AddEvent();
            addEvent.Size = new Size(637, 446);
            panel1.Controls.Add(addEvent);
            UC_Dates userDates = new UC_Dates();
            UC_Blank userBlank = new UC_Blank();

            //resize user controls
            userDates.resize = true;
            userBlank.Size = new Size(77, 44);

            //resize labels
            addEvent.lbl_Monday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Tuesday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Wednesday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Thursday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Friday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Saturday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Sunday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Month.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);

            //resize flow layout panel
            addEvent.flp_Calendar.Size = new Size(581, 300);
            addEvent.flp_Calendar.Location = new Point(22, 93);
        }
    }
}
