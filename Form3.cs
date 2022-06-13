using System;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //close program once the red X is clicked
            this.Close();
        }

        private void addNewItem_Click(object sender, EventArgs e)
        {
            //upon clicking add new item, form3 is hidden, and form4 is open
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            //I will have to think through this once the database is connected
            //upon clicking edit, the program opens form4 and hides form3
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }
    }
}
