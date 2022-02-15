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
    public partial class frm_CustomizeMessageBoxYesNo : Form
    {
        public frm_CustomizeMessageBoxYesNo()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pb_QuestionImage.Image; }
            set { pb_QuestionImage.Image = value; }
        }

        public string Message
        {
            get { return lbl_Msg.Text; }
            set { lbl_Msg.Text = value; }
        }
    }
}
