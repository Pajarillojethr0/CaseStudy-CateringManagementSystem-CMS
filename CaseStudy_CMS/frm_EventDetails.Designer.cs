namespace CaseStudy_CMS
{
    partial class frm_EventDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EventDetails));
            this.lbl_EventName = new System.Windows.Forms.Label();
            this.tb_NameofEvent = new System.Windows.Forms.TextBox();
            this.lbl_GuestCount = new System.Windows.Forms.Label();
            this.nud_NoofGuest = new System.Windows.Forms.NumericUpDown();
            this.lbl_Fname = new System.Windows.Forms.Label();
            this.tb_Firstname = new System.Windows.Forms.TextBox();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.tb_Contact = new System.Windows.Forms.TextBox();
            this.lbl_EventStart = new System.Windows.Forms.Label();
            this.cb_EventStartHour = new System.Windows.Forms.ComboBox();
            this.lbl_EventEnd = new System.Windows.Forms.Label();
            this.tTip_ErrorMessage = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_EventStartMinutes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_EventEndHour = new System.Windows.Forms.ComboBox();
            this.cb_EventEndMinutes = new System.Windows.Forms.ComboBox();
            this.btn_EditDate = new System.Windows.Forms.Button();
            this.lbl_EventDate = new System.Windows.Forms.Label();
            this.mtb_EventDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NoofGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_EventName
            // 
            this.lbl_EventName.AutoSize = true;
            this.lbl_EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventName.ForeColor = System.Drawing.Color.White;
            this.lbl_EventName.Location = new System.Drawing.Point(417, 93);
            this.lbl_EventName.Name = "lbl_EventName";
            this.lbl_EventName.Size = new System.Drawing.Size(114, 20);
            this.lbl_EventName.TabIndex = 0;
            this.lbl_EventName.Text = "Name of Event";
            // 
            // tb_NameofEvent
            // 
            this.tb_NameofEvent.BackColor = System.Drawing.Color.White;
            this.tb_NameofEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NameofEvent.ForeColor = System.Drawing.Color.Black;
            this.tb_NameofEvent.Location = new System.Drawing.Point(557, 93);
            this.tb_NameofEvent.Name = "tb_NameofEvent";
            this.tb_NameofEvent.Size = new System.Drawing.Size(181, 26);
            this.tb_NameofEvent.TabIndex = 4;
            // 
            // lbl_GuestCount
            // 
            this.lbl_GuestCount.AutoSize = true;
            this.lbl_GuestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GuestCount.ForeColor = System.Drawing.Color.White;
            this.lbl_GuestCount.Location = new System.Drawing.Point(417, 138);
            this.lbl_GuestCount.Name = "lbl_GuestCount";
            this.lbl_GuestCount.Size = new System.Drawing.Size(131, 20);
            this.lbl_GuestCount.TabIndex = 0;
            this.lbl_GuestCount.Text = "Number of Guest";
            // 
            // nud_NoofGuest
            // 
            this.nud_NoofGuest.BackColor = System.Drawing.Color.White;
            this.nud_NoofGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_NoofGuest.ForeColor = System.Drawing.Color.Black;
            this.nud_NoofGuest.Location = new System.Drawing.Point(557, 143);
            this.nud_NoofGuest.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_NoofGuest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_NoofGuest.Name = "nud_NoofGuest";
            this.nud_NoofGuest.Size = new System.Drawing.Size(57, 26);
            this.nud_NoofGuest.TabIndex = 5;
            this.nud_NoofGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_NoofGuest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Fname
            // 
            this.lbl_Fname.AutoSize = true;
            this.lbl_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fname.ForeColor = System.Drawing.Color.White;
            this.lbl_Fname.Location = new System.Drawing.Point(35, 95);
            this.lbl_Fname.Name = "lbl_Fname";
            this.lbl_Fname.Size = new System.Drawing.Size(86, 20);
            this.lbl_Fname.TabIndex = 0;
            this.lbl_Fname.Text = "First Name";
            // 
            // tb_Firstname
            // 
            this.tb_Firstname.BackColor = System.Drawing.Color.White;
            this.tb_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Firstname.ForeColor = System.Drawing.Color.Black;
            this.tb_Firstname.Location = new System.Drawing.Point(175, 95);
            this.tb_Firstname.Name = "tb_Firstname";
            this.tb_Firstname.Size = new System.Drawing.Size(181, 26);
            this.tb_Firstname.TabIndex = 1;
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lname.ForeColor = System.Drawing.Color.White;
            this.lbl_Lname.Location = new System.Drawing.Point(35, 138);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(86, 20);
            this.lbl_Lname.TabIndex = 0;
            this.lbl_Lname.Text = "Last Name";
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.BackColor = System.Drawing.Color.White;
            this.tb_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lastname.ForeColor = System.Drawing.Color.Black;
            this.tb_Lastname.Location = new System.Drawing.Point(175, 138);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(181, 26);
            this.tb_Lastname.TabIndex = 2;
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.ForeColor = System.Drawing.Color.White;
            this.lbl_Contact.Location = new System.Drawing.Point(35, 181);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(65, 20);
            this.lbl_Contact.TabIndex = 0;
            this.lbl_Contact.Text = "Contact";
            // 
            // tb_Contact
            // 
            this.tb_Contact.BackColor = System.Drawing.Color.White;
            this.tb_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact.ForeColor = System.Drawing.Color.Black;
            this.tb_Contact.Location = new System.Drawing.Point(175, 181);
            this.tb_Contact.Name = "tb_Contact";
            this.tb_Contact.Size = new System.Drawing.Size(181, 26);
            this.tb_Contact.TabIndex = 3;
            // 
            // lbl_EventStart
            // 
            this.lbl_EventStart.AutoSize = true;
            this.lbl_EventStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventStart.ForeColor = System.Drawing.Color.White;
            this.lbl_EventStart.Location = new System.Drawing.Point(442, 190);
            this.lbl_EventStart.Name = "lbl_EventStart";
            this.lbl_EventStart.Size = new System.Drawing.Size(89, 20);
            this.lbl_EventStart.TabIndex = 0;
            this.lbl_EventStart.Text = "Event Start";
            // 
            // cb_EventStartHour
            // 
            this.cb_EventStartHour.DropDownHeight = 125;
            this.cb_EventStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventStartHour.FormattingEnabled = true;
            this.cb_EventStartHour.IntegralHeight = false;
            this.cb_EventStartHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_EventStartHour.Location = new System.Drawing.Point(557, 189);
            this.cb_EventStartHour.Name = "cb_EventStartHour";
            this.cb_EventStartHour.Size = new System.Drawing.Size(57, 33);
            this.cb_EventStartHour.TabIndex = 6;
            // 
            // lbl_EventEnd
            // 
            this.lbl_EventEnd.AutoSize = true;
            this.lbl_EventEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventEnd.ForeColor = System.Drawing.Color.White;
            this.lbl_EventEnd.Location = new System.Drawing.Point(442, 244);
            this.lbl_EventEnd.Name = "lbl_EventEnd";
            this.lbl_EventEnd.Size = new System.Drawing.Size(83, 20);
            this.lbl_EventEnd.TabIndex = 0;
            this.lbl_EventEnd.Text = "Event End";
            // 
            // tTip_ErrorMessage
            // 
            this.tTip_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.tTip_ErrorMessage.Tag = "";
            this.tTip_ErrorMessage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tTip_ErrorMessage.ToolTipTitle = "First Name is Empty";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(39, 304);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(151, 43);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_EventStartMinutes
            // 
            this.cb_EventStartMinutes.DropDownHeight = 125;
            this.cb_EventStartMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventStartMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventStartMinutes.FormattingEnabled = true;
            this.cb_EventStartMinutes.IntegralHeight = false;
            this.cb_EventStartMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_EventStartMinutes.Location = new System.Drawing.Point(630, 189);
            this.cb_EventStartMinutes.Name = "cb_EventStartMinutes";
            this.cb_EventStartMinutes.Size = new System.Drawing.Size(57, 33);
            this.cb_EventStartMinutes.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(612, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(612, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = ":";
            // 
            // cb_EventEndHour
            // 
            this.cb_EventEndHour.DropDownHeight = 125;
            this.cb_EventEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventEndHour.FormattingEnabled = true;
            this.cb_EventEndHour.IntegralHeight = false;
            this.cb_EventEndHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cb_EventEndHour.Location = new System.Drawing.Point(557, 242);
            this.cb_EventEndHour.Name = "cb_EventEndHour";
            this.cb_EventEndHour.Size = new System.Drawing.Size(57, 33);
            this.cb_EventEndHour.TabIndex = 8;
            // 
            // cb_EventEndMinutes
            // 
            this.cb_EventEndMinutes.DropDownHeight = 125;
            this.cb_EventEndMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EventEndMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EventEndMinutes.FormattingEnabled = true;
            this.cb_EventEndMinutes.IntegralHeight = false;
            this.cb_EventEndMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_EventEndMinutes.Location = new System.Drawing.Point(630, 242);
            this.cb_EventEndMinutes.Name = "cb_EventEndMinutes";
            this.cb_EventEndMinutes.Size = new System.Drawing.Size(57, 33);
            this.cb_EventEndMinutes.TabIndex = 9;
            // 
            // btn_EditDate
            // 
            this.btn_EditDate.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditDate.Image")));
            this.btn_EditDate.Location = new System.Drawing.Point(362, 236);
            this.btn_EditDate.Name = "btn_EditDate";
            this.btn_EditDate.Size = new System.Drawing.Size(32, 33);
            this.btn_EditDate.TabIndex = 10;
            this.btn_EditDate.UseVisualStyleBackColor = true;
            this.btn_EditDate.Visible = false;
            this.btn_EditDate.Click += new System.EventHandler(this.btn_EditDate_Click);
            // 
            // lbl_EventDate
            // 
            this.lbl_EventDate.AutoSize = true;
            this.lbl_EventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventDate.ForeColor = System.Drawing.Color.White;
            this.lbl_EventDate.Location = new System.Drawing.Point(35, 249);
            this.lbl_EventDate.Name = "lbl_EventDate";
            this.lbl_EventDate.Size = new System.Drawing.Size(99, 20);
            this.lbl_EventDate.TabIndex = 0;
            this.lbl_EventDate.Text = "0000-MM-dd";
            this.lbl_EventDate.Visible = false;
            // 
            // mtb_EventDate
            // 
            this.mtb_EventDate.BackColor = System.Drawing.Color.White;
            this.mtb_EventDate.Enabled = false;
            this.mtb_EventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_EventDate.ForeColor = System.Drawing.Color.Black;
            this.mtb_EventDate.Location = new System.Drawing.Point(175, 236);
            this.mtb_EventDate.Name = "mtb_EventDate";
            this.mtb_EventDate.Size = new System.Drawing.Size(177, 26);
            this.mtb_EventDate.TabIndex = 15;
            // 
            // frm_EventDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(777, 453);
            this.Controls.Add(this.mtb_EventDate);
            this.Controls.Add(this.btn_EditDate);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_EventEndMinutes);
            this.Controls.Add(this.cb_EventEndHour);
            this.Controls.Add(this.cb_EventStartMinutes);
            this.Controls.Add(this.cb_EventStartHour);
            this.Controls.Add(this.nud_NoofGuest);
            this.Controls.Add(this.tb_Contact);
            this.Controls.Add(this.lbl_EventEnd);
            this.Controls.Add(this.tb_Lastname);
            this.Controls.Add(this.lbl_EventStart);
            this.Controls.Add(this.lbl_Contact);
            this.Controls.Add(this.tb_Firstname);
            this.Controls.Add(this.lbl_Lname);
            this.Controls.Add(this.tb_NameofEvent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_EventDate);
            this.Controls.Add(this.lbl_Fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_GuestCount);
            this.Controls.Add(this.lbl_EventName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EventDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_EventDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_NoofGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EventName;
        private System.Windows.Forms.Label lbl_GuestCount;
        private System.Windows.Forms.Label lbl_Fname;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.Label lbl_EventStart;
        private System.Windows.Forms.Label lbl_EventEnd;
        private System.Windows.Forms.ToolTip tTip_ErrorMessage;
        public System.Windows.Forms.TextBox tb_NameofEvent;
        public System.Windows.Forms.NumericUpDown nud_NoofGuest;
        public System.Windows.Forms.TextBox tb_Firstname;
        public System.Windows.Forms.TextBox tb_Lastname;
        public System.Windows.Forms.TextBox tb_Contact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbl_EventDate;
        private System.Windows.Forms.MaskedTextBox mtb_EventDate;
        public System.Windows.Forms.Button btn_EditDate;
        public System.Windows.Forms.ComboBox cb_EventStartHour;
        public System.Windows.Forms.ComboBox cb_EventStartMinutes;
        public System.Windows.Forms.ComboBox cb_EventEndHour;
        public System.Windows.Forms.ComboBox cb_EventEndMinutes;
        public System.Windows.Forms.Button btn_Save;
    }
}