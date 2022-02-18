using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CaseStudy_CMS
{
    public partial class UC_Blank1 : UserControl
    {
        public UC_Blank1()
        {
            InitializeComponent();
        }

        public bool doResize;

        public void ChangeSize()
        {
            if (doResize == true)
            {
                this.Size = new Size(77, 44);
            }
        }

        private void UC_Blank1_Load(object sender, EventArgs e)
        {
            UC_AddEvent addEvent = new UC_AddEvent();
            doResize = addEvent.resize;
            ChangeSize();
        }
    }
}
