using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_CMS
{
    public partial class UC_Food : UserControl
    {
        public string foodID;

        public UC_Food()
        {
            InitializeComponent();

        }

        private void UC_Food_Load(object sender, EventArgs e)
        {
            //set size because for some reason nag iiba
            this.Size = new Size(240, 245);
            pb_Food.Size = new Size(230, 150);
            btn_Order.Size = new Size(230, 40);

            //set location
            lbl_FoodName.Location = new Point(8,13);
            lbl_Price.Location = new Point(195, 0);
            btn_Order.Location = new Point(5, 200);
            pb_Food.Location = new Point(4, 45);
        }
    }
}
