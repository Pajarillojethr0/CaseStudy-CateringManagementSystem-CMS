namespace CaseStudy_CMS
{
    partial class UC_Event
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
            this.lbl_EventName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_EventName
            // 
            this.lbl_EventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventName.Location = new System.Drawing.Point(3, 4);
            this.lbl_EventName.Name = "lbl_EventName";
            this.lbl_EventName.Size = new System.Drawing.Size(366, 23);
            this.lbl_EventName.TabIndex = 0;
            this.lbl_EventName.Text = "Event Name";
            this.lbl_EventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_EventName);
            this.Name = "UC_Event";
            this.Size = new System.Drawing.Size(360, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_EventName;
    }
}
