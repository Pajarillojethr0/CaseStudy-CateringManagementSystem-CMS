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
    public partial class ResizablePanel : UserControl
    {
        public ResizablePanel()
        {
            InitializeComponent();
        }
        bool isResizeMode;
        private void ResizablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = true;
            }
        }

        private void ResizablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizeMode)
            {
                this.Size = new Size(e.X, e.Y);
            }

            
        }

        private void ResizablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizeMode = false;
            }
        }

        private void ResizablePanel_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
