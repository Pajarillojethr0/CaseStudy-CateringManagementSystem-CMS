namespace CaseStudy_CMS
{
    partial class UC_Food
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
            this.pb_Food = new System.Windows.Forms.PictureBox();
            this.btn_Order = new System.Windows.Forms.Button();
            this.lbl_FoodName = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Food
            // 
            this.pb_Food.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Food.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pb_Food.Location = new System.Drawing.Point(5, 47);
            this.pb_Food.Name = "pb_Food";
            this.pb_Food.Size = new System.Drawing.Size(230, 150);
            this.pb_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Food.TabIndex = 5;
            this.pb_Food.TabStop = false;
            // 
            // btn_Order
            // 
            this.btn_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order.BackColor = System.Drawing.Color.DimGray;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.Color.White;
            this.btn_Order.Location = new System.Drawing.Point(6, 203);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(230, 40);
            this.btn_Order.TabIndex = 7;
            this.btn_Order.Text = "Order";
            this.btn_Order.UseVisualStyleBackColor = false;
            // 
            // lbl_FoodName
            // 
            this.lbl_FoodName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodName.ForeColor = System.Drawing.Color.White;
            this.lbl_FoodName.Location = new System.Drawing.Point(8, 23);
            this.lbl_FoodName.Name = "lbl_FoodName";
            this.lbl_FoodName.Size = new System.Drawing.Size(229, 20);
            this.lbl_FoodName.TabIndex = 8;
            this.lbl_FoodName.Text = "Name";
            this.lbl_FoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Price
            // 
            this.lbl_Price.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Price.Location = new System.Drawing.Point(195, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(45, 24);
            this.lbl_Price.TabIndex = 9;
            this.lbl_Price.Text = "0.00";
            // 
            // UC_Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_FoodName);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.pb_Food);
            this.Name = "UC_Food";
            this.Size = new System.Drawing.Size(240, 245);
            this.Load += new System.EventHandler(this.UC_Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_Food;
        private System.Windows.Forms.Button btn_Order;
        public System.Windows.Forms.Label lbl_FoodName;
        public System.Windows.Forms.Label lbl_Price;
    }
}
