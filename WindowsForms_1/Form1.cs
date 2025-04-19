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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // wnta katktab how kaykteb m3ak f Another part
        {
            textBox2.Text = textBox1.Text;
            label1.Text = textBox1.Text; // wnta katkte how idir edite f label 
        }

        // ************** enable **************

        // read only = f4 + behavior + enable(false)
        // *************** to do if i click in this button not do any enable if 
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            // button1.Enabled = false;  // *** Disable for the button 1 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            // button1.Enabled = true; // *** Enable button 1
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false; // to divisable the text box from the form disign . not clear but remove it oon the disign
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true; // noe we do it for show it 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red; // do the text box on Red 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White; // do it On white 
            // button1.BackColor = Color.Red; // for change any boutton to another color 
            this.BackColor = Color.Silver; // if you want to change backround of the form    use this 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Text = "my form";  // chane the form name 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Mohammed abu-hadhood"; // chang the label name 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Close(); // close this form
        }

        // ***** tap index and tap stop you can use : size -> tabindex for index each one 
        // ***** size -> Tap sotop = false
    }
}
