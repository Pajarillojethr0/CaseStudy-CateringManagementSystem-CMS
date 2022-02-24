using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(panel_EventDetails);
            panel_EventDetails.Dock = DockStyle.Fill;
        }

        private void mtb_EventDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tTip_ErrorMessage.ToolTipTitle = "Invalid Input";
            tTip_ErrorMessage.Show("We're sorry, but only digits (0-9) are allowed in dates.", mtb_EventDate);
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
            int startEventHour = Convert.ToInt32(cb_EventStartHour.Text);
            int startEventMinutes = Convert.ToInt32(cb_EventStartMinutes.Text);
            int endEventHour = Convert.ToInt32(cb_EventEndHour.Text);
            int endEventMinute = Convert.ToInt32(cb_EventEndMinutes.Text);

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
                
                if(eventID == null)
                {
                    //SQLQueries queries = new SQLQueries();
                    //queries.InsertEventDetails(nameofEvent, noofGuest, firstName, lastName, contact, date);
                    //this.Close();
                   // MessageBox.Show(eventID.ToString());
                }
                else
                {
                    MessageBox.Show(eventID.ToString() + " ============ Edit");
                }
               
            }
        }

        private void btn_EditDate_Click(object sender, EventArgs e)
        {
            mtb_EventDate.Enabled = true;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (panel_Main.Contains(panel_EventDetails))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(flp_Food);
                flp_Food.Dock = DockStyle.Fill;
                this.Size = new Size(1015, 684);
                this.Location = new Point(275, 13);
                loadFood();
            }
            else if (panel_Main.Contains(flp_Food))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(panel_Venue);
                panel_Venue.Dock = DockStyle.Fill;
            }
        }
        public void loadFood()
        {
            SQLQueries queries = new SQLQueries();
            // this block of code is to add the user control in the flowlayout
            string query = "SELECT * FROM foodmenu";

            ConnectDatabase conDb = new ConnectDatabase();
            conDb.connectSql();
            //open connection
            conDb.sqlConnection.Open();
            MySqlCommand sqlCommand;

            MySqlDataReader sqlDataReader;
            sqlCommand = new MySqlCommand(query, conDb.sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader();

            UC_Food userFood;

            while (sqlDataReader.Read())
            {
                userFood = new UC_Food();
                userFood.foodID = (sqlDataReader["food_ID"].ToString());
                userFood.lbl_FoodName.Text = (sqlDataReader["Food_Name"].ToString());
                userFood.lbl_Price.Text = (sqlDataReader["Price"].ToString());

                //get im
                byte[] imgData = (byte[])(sqlDataReader["Food_Img"]);
                MemoryStream ms = new MemoryStream(imgData);
                userFood.pb_Food.Image = Image.FromStream(ms);
                
                flp_Food.Controls.Add(userFood);
            }
            sqlDataReader.Close();
            conDb.sqlConnection.Close();
        }
        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (panel_Main.Contains(panel_EventDetails))
            {
                this.Close();
            }
            else if (panel_Main.Contains(flp_Food))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(panel_EventDetails);
                panel_EventDetails.Dock = DockStyle.Fill;
                panel_EventDetails.Location = new Point(46, 77);
                this.Size = new Size(850, 483);
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }
            else if (panel_Main.Contains(panel_Venue))
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(flp_Food);
                flp_Food.Dock = DockStyle.Fill;
            }

        }
    }
}
