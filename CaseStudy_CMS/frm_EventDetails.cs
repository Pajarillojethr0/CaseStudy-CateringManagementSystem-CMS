using System;
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
    public partial class frm_EventDetails : Form
    {
        //public bool doResize;
        public string eventID;
        public frm_EventDetails()
        {
            InitializeComponent();
            UC_Dates userDates = new UC_Dates();
            lbl_EventDate.Text = userDates.fullDate;
        }

        private void frm_EventDetails_Load(object sender, EventArgs e)
        {
            mtb_EventDate.Text = lbl_EventDate.Text;
            mtb_EventDate.Mask = "0000-00-00";
            mtb_EventDate.MaskInputRejected += new MaskInputRejectedEventHandler(mtb_EventDate_MaskInputRejected);
            tb_Contact.MaxLength = 11;
      
            SQLQueries queries = new SQLQueries();
           // queries.DateFormat(eventID);
        }

        private void mtb_EventDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tTip_ErrorMessage.ToolTipTitle = "Invalid Input";
            tTip_ErrorMessage.Show("We're sorry, but only digits (0-9) are allowed in dates.", mtb_EventDate);
        }

        private void lbl_EventDate_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //store fields value to variable
            string nameofEvent = tb_NameofEvent.Text;
            string noofGuest = nud_NoofGuest.Value.ToString();
            string firstName = tb_Firstname.Text;
            string lastName = tb_Lastname.Text;
            string contact = tb_Contact.Text;
            string date = mtb_EventDate.Text;
        
            ///check if fields are empty
            if (string.IsNullOrEmpty(nameofEvent) || string.IsNullOrEmpty(noofGuest) ||
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(date) ||
                string.IsNullOrEmpty(cb_EventStartHour.Text) || string.IsNullOrEmpty(cb_EventStartMinutes.Text) ||
                string.IsNullOrEmpty(cb_EventEndHour.Text) || string.IsNullOrEmpty(cb_EventEndMinutes.Text))
            {
                MyMessageBox.ShowMessage("Please fill all empty fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SQLQueries queries = new SQLQueries();
                queries.InsertEventDetails(nameofEvent, noofGuest, firstName, lastName, contact, date);
                this.Close();
            }
        }

        private void btn_EditDate_Click(object sender, EventArgs e)
        {
            mtb_EventDate.Enabled = true;
        }

      
    }
}
