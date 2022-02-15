using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_CMS
{
    public partial class frm_CustomizeMessageBox : Form
    {
        public frm_CustomizeMessageBox()
        {
            InitializeComponent();
        }

        public string Message
        {
            get { return lbl_Msg.Text; }
            set { lbl_Msg.Text = value; }
        }

        public Image MessageIcon
        {
            get { return pb_InformationImage.Image; }
            set { pb_InformationImage.Image = value; }
        }

        private void pb_InformationImage_Click(object sender, EventArgs e)
        {

        }
    }
}
