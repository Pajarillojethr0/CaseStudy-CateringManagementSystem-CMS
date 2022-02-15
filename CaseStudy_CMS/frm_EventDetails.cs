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
        public string eventID;
        public frm_EventDetails()
        {
            InitializeComponent();
            UC_Dates userDates = new UC_Dates();
            lbl_EventDate.Text = userDates.fullDate;
        }
        
        private void btn_Venue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is when you click venue");
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
    }
}
