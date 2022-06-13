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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if user clicks the X, close the application
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //if user clicks the cancel button, hide this form, and open form 3
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //convert user input accordingly and store it in a appropriate variable
            int item_ID = int.Parse(itemID.Text);
            string item_Name = itemName.Text;
            string storage_Location = storageLocation.Text;
            double cost_Case = double.Parse(costCase.Text);
            string dept = department.Text;
            int case_QuantityInStock = int.Parse(caseQuantityInStock.Text);
            int each_QuantityInStock = int.Parse(eachQuantityInStock.Text);
            int each_CaseQuantity  = int.Parse(eachCaseQuantity.Text);
            string vend = vendor.Text;
            string base_UnitOfMeasure = baseUnitOfMeasure.Text;

            //declare object
            var save = new SaveInventoryItem();
            //cast the method to a class and pass local variables as args
            save.saveInventory(item_ID, item_Name, storage_Location, cost_Case, dept, case_QuantityInStock, each_QuantityInStock, each_CaseQuantity, vend, base_UnitOfMeasure);
        }
    }
}
