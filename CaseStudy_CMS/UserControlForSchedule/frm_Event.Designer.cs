namespace CaseStudy_CMS
{
    partial class frm_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Event));
            this.flp_EventContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_NewEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flp_EventContainer
            // 
            this.flp_EventContainer.AutoScroll = true;
            this.flp_EventContainer.BackColor = System.Drawing.Color.DimGray;
            this.flp_EventContainer.Location = new System.Drawing.Point(23, 28);
            this.flp_EventContainer.Name = "flp_EventContainer";
            this.flp_EventContainer.Size = new System.Drawing.Size(366, 165);
            this.flp_EventContainer.TabIndex = 0;
            // 
            // btn_NewEvent
            // 
            this.btn_NewEvent.FlatAppearance.BorderSize = 0;
            this.btn_NewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewEvent.ForeColor = System.Drawing.Color.White;
            this.btn_NewEvent.Image = ((System.Drawing.Image)(resources.GetObject("btn_NewEvent.Image")));
            this.btn_NewEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NewEvent.Location = new System.Drawing.Point(271, 215);
            this.btn_NewEvent.Name = "btn_NewEvent";
            this.btn_NewEvent.Size = new System.Drawing.Size(118, 33);
            this.btn_NewEvent.TabIndex = 1;
            this.btn_NewEvent.Text = "     Event";
            this.btn_NewEvent.UseVisualStyleBackColor = true;
            this.btn_NewEvent.Click += new System.EventHandler(this.btn_NewEvent_Click);
            this.btn_NewEvent.MouseEnter += new System.EventHandler(this.btn_NewEvent_MouseEnter);
            this.btn_NewEvent.MouseLeave += new System.EventHandler(this.btn_NewEvent_MouseLeave);
            // 
            // frm_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(413, 273);
            this.Controls.Add(this.btn_NewEvent);
            this.Controls.Add(this.flp_EventContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Event";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_NewEvent;
        public System.Windows.Forms.FlowLayoutPanel flp_EventContainer;
    }
}