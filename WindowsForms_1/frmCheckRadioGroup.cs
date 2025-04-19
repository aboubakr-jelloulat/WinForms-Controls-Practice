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
    public partial class frmCheckRadioGroup : Form
    {
        public frmCheckRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkReceiveEmail.Checked.ToString(), "Result"); // print the checkbox value at message box it is a true or false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = chkReceiveEmail.Checked; // if check box = false button disable if true is enable // use ckh with checkbox 
            // in this case is by default is enable but how make it by default diable f4 --> Enable --> false
        }

        // **** Radio Button you can use only one of all
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Checked.ToString(), "button 1");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = false;  // make the group Enable 
        }


        // ***** Tag is a variable you store on it data (int , string .... )
        


    }
}
