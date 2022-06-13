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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //close program once the red X is clicked
            this.Close();
        }

        private void itemManagementBtn_Click(object sender, EventArgs e)
        {
            //once item management is clicked, hide form2 and display form3
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
