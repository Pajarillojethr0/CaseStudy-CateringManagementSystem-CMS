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
    public partial class formResize : Form
    {
        public formResize()
        {
            InitializeComponent();
        }

        private void formResize_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_AddEvent addEvent = new UC_AddEvent();
            fillPanel.Controls.Clear();
            fillPanel.Controls.Add(addEvent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_AddEvent addEvent = new UC_AddEvent();
            fillPanel.Controls.Clear();
            fillPanel.Size = new Size(637, 446);
            addEvent.lbl_Monday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Monday.Location = new Point(126, 76);
            //
            addEvent.lbl_Tuesday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Tuesday.Location = new Point(203, 76);
            //
            addEvent.lbl_Wednesday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Wednesday.Location = new Point(287, 76);
            //
            addEvent.lbl_Thursday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Thursday.Location = new Point(370, 76);
            //
            addEvent.lbl_Friday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Friday.Location = new Point(459, 76);
            //
            addEvent.lbl_Saturday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Saturday.Location = new Point(534, 76);
            //
            addEvent.lbl_Sunday.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            addEvent.lbl_Sunday.Location = new Point(38, 77);
            addEvent.lbl_Month.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            addEvent.lbl_Month.Location = new Point(3,33);
            addEvent.lbl_Month.Size = new Size(618, 31);

            //resize flow layout panel
            addEvent.flp_Calendar.Size = new Size(581, 300);
            addEvent.flp_Calendar.Location = new Point(22, 93);
            fillPanel.Controls.Add(addEvent);

            UC_Dates ucDates = new UC_Dates();
            UC_Blank ucBlank = new UC_Blank();
            ucDates.newSize(77, 44);

        }
    }
}
