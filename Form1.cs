using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //close program once the red X is clicked
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //click login to login - hide login form and display form2
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
