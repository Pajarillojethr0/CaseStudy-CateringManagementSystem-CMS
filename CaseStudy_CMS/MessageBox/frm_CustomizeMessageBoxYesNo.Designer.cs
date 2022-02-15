namespace CaseStudy_CMS
{
    partial class frm_CustomizeMessageBoxYesNo
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
            this.btn_Okay = new System.Windows.Forms.Button();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.pb_QuestionImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Okay
            // 
            this.btn_Okay.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Okay.Location = new System.Drawing.Point(325, 217);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(134, 32);
            this.btn_Okay.TabIndex = 4;
            this.btn_Okay.Text = "&No";
            this.btn_Okay.UseVisualStyleBackColor = true;
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Msg.Location = new System.Drawing.Point(101, 28);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(358, 175);
            this.lbl_Msg.TabIndex = 3;
            this.lbl_Msg.Text = "label1";
            this.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_QuestionImage
            // 
            this.pb_QuestionImage.Image = global::CaseStudy_CMS.Properties.Resources.Question;
            this.pb_QuestionImage.Location = new System.Drawing.Point(22, 87);
            this.pb_QuestionImage.Name = "pb_QuestionImage";
            this.pb_QuestionImage.Size = new System.Drawing.Size(60, 60);
            this.pb_QuestionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_QuestionImage.TabIndex = 5;
            this.pb_QuestionImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Yes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_CustomizeMessageBoxYesNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pb_QuestionImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.lbl_Msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CustomizeMessageBoxYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuestionImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_QuestionImage;
        private System.Windows.Forms.Button btn_Okay;
        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Button button1;
    }
}