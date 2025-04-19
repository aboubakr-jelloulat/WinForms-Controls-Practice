using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();

            frm1.Show();  // *** add form : addnew item   *** link between 2 form and close   f
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();

            frm1.ShowDialog(); // dialog no return is very helpful
        }

        private void btnMessgeBoxForm_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBox(); // creat a new form  like : enter to this button to link it to anotyher form show the message box
            frm1.ShowDialog(); // show as a diagonal no return 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm_checkbox_radio = new frmCheckRadioGroup();
            frm_checkbox_radio.ShowDialog();
        }
    }
}
