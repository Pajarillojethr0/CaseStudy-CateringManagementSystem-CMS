namespace CaseStudy_CMS
{
    partial class frm_CustomizeMessageBox
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
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.pb_InformationImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_InformationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Msg.Location = new System.Drawing.Point(101, 28);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(358, 175);
            this.lbl_Msg.TabIndex = 0;
            this.lbl_Msg.Text = "label1";
            this.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Okay
            // 
            this.btn_Okay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Okay.Location = new System.Drawing.Point(325, 217);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(134, 32);
            this.btn_Okay.TabIndex = 1;
            this.btn_Okay.Text = "&Okay";
            this.btn_Okay.UseVisualStyleBackColor = true;
            // 
            // pb_InformationImage
            // 
            this.pb_InformationImage.Image = global::CaseStudy_CMS.Properties.Resources.Information;
            this.pb_InformationImage.Location = new System.Drawing.Point(22, 87);
            this.pb_InformationImage.Name = "pb_InformationImage";
            this.pb_InformationImage.Size = new System.Drawing.Size(60, 60);
            this.pb_InformationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_InformationImage.TabIndex = 2;
            this.pb_InformationImage.TabStop = false;
            this.pb_InformationImage.Click += new System.EventHandler(this.pb_InformationImage_Click);
            // 
            // frm_CustomizeMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pb_InformationImage);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.lbl_Msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CustomizeMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pb_InformationImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Button btn_Okay;
        private System.Windows.Forms.PictureBox pb_InformationImage;
    }
}