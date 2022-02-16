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
    public partial class frm_AdminDashboard : Form
    {
        UC_Account userAccount;
        UC_AddEvent userAE;
        UC_History userHistory;
        UC_Inventory userInventory;
        UC_Maintenance userMaintenance;
        UC_Report userReport;
        UC_Task userTask;
        public frm_AdminDashboard()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            fillPanel.Controls.Clear();
            fillPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(0, 122, 204);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //load Account usercontrol to panel
            fillPanel.Controls.Clear();
        }

        private void btn_AddEvent_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(0, 122, 204);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //load Add Event usercontrol to panel
            userAE = new UC_AddEvent();
            addUserControl(userAE);
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(0, 122, 204);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //call userControl then put it to the panel
            userTask = new UC_Task();
            addUserControl(userTask);
        }

        private void btn_Inventory_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(0, 122, 204);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //load Account usercontrol to panel
            userInventory = new UC_Inventory();
            addUserControl(userInventory);
        }

        private void btn_Maintenance_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(0, 122, 204);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //load Account usercontrol to panel
            userMaintenance = new UC_Maintenance();
            addUserControl(userMaintenance);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(0, 122, 204);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //load Account usercontrol to panel
            userReport = new UC_Report();
            addUserControl(userReport);
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(0, 122, 204);
            btn_Account.BackColor = Color.FromArgb(29, 45, 57);

            //load Account usercontrol to panel
            userHistory = new UC_History();
            addUserControl(userHistory);
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            //slight animation for popup? xD
            btn_Home.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_AddEvent.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Task.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Inventory.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Maintenance.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Report.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_History.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            btn_Account.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Regular);

            //change color
            btn_Home.BackColor = Color.FromArgb(29, 45, 57);
            btn_AddEvent.BackColor = Color.FromArgb(29, 45, 57);
            btn_Task.BackColor = Color.FromArgb(29, 45, 57);
            btn_Inventory.BackColor = Color.FromArgb(29, 45, 57);
            btn_Maintenance.BackColor = Color.FromArgb(29, 45, 57);
            btn_Report.BackColor = Color.FromArgb(29, 45, 57);
            btn_History.BackColor = Color.FromArgb(29, 45, 57);
            btn_Account.BackColor = Color.FromArgb(0, 122, 204);

            //load Account usercontrol to panel
            userAccount = new UC_Account();
            addUserControl(userAccount);
        }
        
    }
}
