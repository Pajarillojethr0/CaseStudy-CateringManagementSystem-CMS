namespace CaseStudy_CMS
{
    partial class frm_AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdminDashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_Account = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Maintenance = new System.Windows.Forms.Button();
            this.btn_Inventory = new System.Windows.Forms.Button();
            this.btn_Task = new System.Windows.Forms.Button();
            this.btn_AddEvent = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_User = new System.Windows.Forms.Label();
            this.pb_User = new System.Windows.Forms.PictureBox();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.uC_AddEvent1 = new CaseStudy_CMS.UC_AddEvent();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).BeginInit();
            this.fillPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.sidePanel.Controls.Add(this.btn_Account);
            this.sidePanel.Controls.Add(this.btn_History);
            this.sidePanel.Controls.Add(this.btn_Report);
            this.sidePanel.Controls.Add(this.btn_Maintenance);
            this.sidePanel.Controls.Add(this.btn_Inventory);
            this.sidePanel.Controls.Add(this.btn_Task);
            this.sidePanel.Controls.Add(this.btn_AddEvent);
            this.sidePanel.Controls.Add(this.btn_Home);
            this.sidePanel.Controls.Add(this.lbl_User);
            this.sidePanel.Controls.Add(this.pb_User);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 700);
            this.sidePanel.TabIndex = 0;
            // 
            // btn_Account
            // 
            this.btn_Account.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Account.FlatAppearance.BorderSize = 0;
            this.btn_Account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = ((System.Drawing.Image)(resources.GetObject("btn_Account.Image")));
            this.btn_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Account.Location = new System.Drawing.Point(0, 615);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(200, 50);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Text = "Account";
            this.btn_Account.UseVisualStyleBackColor = true;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_History
            // 
            this.btn_History.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_History.FlatAppearance.BorderSize = 0;
            this.btn_History.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.White;
            this.btn_History.Image = ((System.Drawing.Image)(resources.GetObject("btn_History.Image")));
            this.btn_History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Location = new System.Drawing.Point(0, 560);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(200, 50);
            this.btn_History.TabIndex = 0;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Image = ((System.Drawing.Image)(resources.GetObject("btn_Report.Image")));
            this.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Report.Location = new System.Drawing.Point(0, 505);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(200, 50);
            this.btn_Report.TabIndex = 0;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_Maintenance
            // 
            this.btn_Maintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Maintenance.FlatAppearance.BorderSize = 0;
            this.btn_Maintenance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maintenance.ForeColor = System.Drawing.Color.White;
            this.btn_Maintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maintenance.Image")));
            this.btn_Maintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Maintenance.Location = new System.Drawing.Point(0, 450);
            this.btn_Maintenance.Name = "btn_Maintenance";
            this.btn_Maintenance.Size = new System.Drawing.Size(200, 50);
            this.btn_Maintenance.TabIndex = 0;
            this.btn_Maintenance.Text = "  Maintenance";
            this.btn_Maintenance.UseVisualStyleBackColor = true;
            this.btn_Maintenance.Click += new System.EventHandler(this.btn_Maintenance_Click);
            // 
            // btn_Inventory
            // 
            this.btn_Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Inventory.FlatAppearance.BorderSize = 0;
            this.btn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventory.ForeColor = System.Drawing.Color.White;
            this.btn_Inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inventory.Image")));
            this.btn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventory.Location = new System.Drawing.Point(0, 395);
            this.btn_Inventory.Name = "btn_Inventory";
            this.btn_Inventory.Size = new System.Drawing.Size(200, 50);
            this.btn_Inventory.TabIndex = 0;
            this.btn_Inventory.Text = "Inventory";
            this.btn_Inventory.UseVisualStyleBackColor = true;
            this.btn_Inventory.Click += new System.EventHandler(this.btn_Inventory_Click);
            // 
            // btn_Task
            // 
            this.btn_Task.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Task.FlatAppearance.BorderSize = 0;
            this.btn_Task.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Task.ForeColor = System.Drawing.Color.White;
            this.btn_Task.Image = ((System.Drawing.Image)(resources.GetObject("btn_Task.Image")));
            this.btn_Task.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Task.Location = new System.Drawing.Point(0, 340);
            this.btn_Task.Name = "btn_Task";
            this.btn_Task.Size = new System.Drawing.Size(200, 50);
            this.btn_Task.TabIndex = 0;
            this.btn_Task.Text = "Task";
            this.btn_Task.UseVisualStyleBackColor = true;
            this.btn_Task.Click += new System.EventHandler(this.btn_Task_Click);
            // 
            // btn_AddEvent
            // 
            this.btn_AddEvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_AddEvent.FlatAppearance.BorderSize = 0;
            this.btn_AddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddEvent.ForeColor = System.Drawing.Color.White;
            this.btn_AddEvent.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddEvent.Image")));
            this.btn_AddEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEvent.Location = new System.Drawing.Point(0, 285);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Size = new System.Drawing.Size(200, 50);
            this.btn_AddEvent.TabIndex = 0;
            this.btn_AddEvent.Text = "Add Event";
            this.btn_AddEvent.UseVisualStyleBackColor = true;
            this.btn_AddEvent.Click += new System.EventHandler(this.btn_AddEvent_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 230);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(200, 50);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.White;
            this.lbl_User.Location = new System.Drawing.Point(25, 167);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(150, 23);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "username";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_User
            // 
            this.pb_User.Image = ((System.Drawing.Image)(resources.GetObject("pb_User.Image")));
            this.pb_User.Location = new System.Drawing.Point(25, 22);
            this.pb_User.Name = "pb_User";
            this.pb_User.Size = new System.Drawing.Size(150, 130);
            this.pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_User.TabIndex = 0;
            this.pb_User.TabStop = false;
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.fillPanel.Controls.Add(this.uC_AddEvent1);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(200, 0);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(1000, 700);
            this.fillPanel.TabIndex = 2;
            // 
            // uC_AddEvent1
            // 
            this.uC_AddEvent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_AddEvent1.Location = new System.Drawing.Point(0, 3);
            this.uC_AddEvent1.Name = "uC_AddEvent1";
            this.uC_AddEvent1.Size = new System.Drawing.Size(1006, 684);
            this.uC_AddEvent1.TabIndex = 0;
            // 
            // frm_AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AdminDashboard";
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_User)).EndInit();
            this.fillPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.PictureBox pb_User;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btn_Account;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Maintenance;
        private System.Windows.Forms.Button btn_Inventory;
        private System.Windows.Forms.Button btn_Task;
        private System.Windows.Forms.Button btn_AddEvent;
        private System.Windows.Forms.Button btn_Home;
        private UC_AddEvent uC_AddEvent1;
    }
}