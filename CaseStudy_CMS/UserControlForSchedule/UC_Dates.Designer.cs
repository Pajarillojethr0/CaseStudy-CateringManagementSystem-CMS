namespace CaseStudy_CMS
{
    partial class UC_Dates
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_day = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_EventCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_day
            // 
            this.lbl_day.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_day.AutoSize = true;
            this.lbl_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day.ForeColor = System.Drawing.Color.White;
            this.lbl_day.Location = new System.Drawing.Point(13, 14);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(27, 20);
            this.lbl_day.TabIndex = 2;
            this.lbl_day.Text = "00";
            // 
            // lbl_EventCount
            // 
            this.lbl_EventCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EventCount.AutoSize = true;
            this.lbl_EventCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.lbl_EventCount.Location = new System.Drawing.Point(51, 33);
            this.lbl_EventCount.Name = "lbl_EventCount";
            this.lbl_EventCount.Size = new System.Drawing.Size(0, 31);
            this.lbl_EventCount.TabIndex = 2;
            // 
            // UC_Dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.lbl_EventCount);
            this.Controls.Add(this.lbl_day);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Dates";
            this.Size = new System.Drawing.Size(128, 87);
            this.toolTip1.SetToolTip(this, "Add Event");
            this.Load += new System.EventHandler(this.UC_Dates_Load);
            this.Click += new System.EventHandler(this.UC_Dates_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label lbl_EventCount;
    }
}
