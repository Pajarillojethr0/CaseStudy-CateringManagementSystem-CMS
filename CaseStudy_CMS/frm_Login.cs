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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MyMessageBox.ShowMessage("Are you sure you want to Exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                //close application
                Environment.Exit(0);
            }
        }

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            if(tb_Username.Text.Equals("Enter your Username"))//check if txtbox username is equals to placeholder
            {
                tb_Username.Text = "";
                tb_Username.ForeColor = Color.Black;
            }
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_Username.Text)) //check if txtbox is empty
            {
                tb_Username.Text = "Enter your Username";
                tb_Username.ForeColor = Color.Gray;
            }
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            if (tb_Password.Text.Equals("Enter your Password"))//check if txtbox password is equals to placeholder
            {
                tb_Password.UseSystemPasswordChar = true;// to hide the pass
                tb_Password.Text = "";
                tb_Password.ForeColor = Color.Black;
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Password.Text)) //check if txtbox is empty
            {
                tb_Password.UseSystemPasswordChar = false;
                tb_Password.Text = "Enter your Password";
                tb_Password.ForeColor = Color.Gray;
            }
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //call the class SQLQueries
            SQLQueries queries = new SQLQueries();
            //then pass the value of textbox username and password as a argument
            string returnOutcome = (queries.Login(tb_Username.Text, tb_Password.Text));

            if (returnOutcome.Equals("Success"))
            {
                frm_AdminDashboard admin = new frm_AdminDashboard();
                admin.Show();
                this.Dispose(false);
            }
            else
            {
                lbl_Display.Visible = true;
                lbl_Display.Text = "incorrect username or password";
            }
        }
    }
}
