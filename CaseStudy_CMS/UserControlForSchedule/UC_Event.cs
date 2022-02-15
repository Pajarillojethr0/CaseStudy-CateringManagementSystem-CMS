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
    public partial class UC_Event : UserControl
    {
        public string eventID;

        public UC_Event()
        {
            InitializeComponent();
           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            SQLQueries queries = new SQLQueries();
            queries.EditEvent(eventID);
            
        }
    }
}
