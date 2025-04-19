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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("hi this is a message ?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi this is a message box with title ?", "this is title");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // if okey do something 
                MessageBox.Show("User Passed");
            }
            else
                MessageBox.Show("I3awen rebi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) // Question icon abort ..
            {
                // if okey do something 
                MessageBox.Show("User Passed");
            }
            else
                MessageBox.Show("I3awen rebi");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) == DialogResult.OK)  // last parametere make the buttyon 2 the default and not the first one ok
            {
                // if okey do something 
                MessageBox.Show("User Passed");
            }
            else
                MessageBox.Show("I3awen rebi");

        }
    }
}

