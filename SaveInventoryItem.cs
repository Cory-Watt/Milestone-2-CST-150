using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    public class SaveInventoryItem
    {
        //declare local variables
        public int item_ID;
        public string item_Name;
        public string storage_Location;
        public double cost_Case;
        public string dept;
        public int case_QuantityInStock;
        public int each_QuantityInStock;
        public int each_CaseQuantity;
        public string vend;
        public string base_UnitOfMeasure;

        //constructor
        public SaveInventoryItem()
        {
            this.item_ID = item_ID;
            this.item_Name = item_Name;
            this.storage_Location = storage_Location;
            this.cost_Case = cost_Case;
            this.dept = dept;
            this.case_QuantityInStock = case_QuantityInStock;
            this.each_CaseQuantity = each_CaseQuantity;
            this.vend = vend;
            this.base_UnitOfMeasure = base_UnitOfMeasure;
        }

        //setter methods
        public int getItemID()
        {
            return item_ID; //the item's unique ID
        }
        public string getItemName()
        {
            return item_Name; // item name
        }
        public string getStorageLocation()
        {
            return storage_Location; // location the item will be stored
        }
        public double getCostCase()
        {
            return cost_Case; //the cost the store pays per case
        }
        public string getDepartment()
        {
            return dept; //the department where the item is on display for purchase
        }
        public int getCaseQuantityInStock()
        {
            return case_QuantityInStock; //the quantity of cases they have on hand
        }
        public int getEachQuantityInStock()
        {
            return each_QuantityInStock; //the quantity of each item that is in a broken case but not yet sold
        }
        public int getEachCaseQuantity()
        {
            return each_CaseQuantity; //how many items are in a full case
        }
        public string getVendor()
        {
            return vend; //the vendor the store purchases the goods from
        }
        public string getBaseUnitOfMeasure()
        {
            return base_UnitOfMeasure; //base unit of measure: each, slice, #10 can, etc.
        }

        //this method receives the args from form4.cs, which is collected from the user's input on the add new item screen
        //this simulates storing the data in the database
        public void saveInventory(int item_ID, string item_Name, string storage_Location, double cost_Case, string dept, 
            int case_QuantityInStock, int each_QuantityInStock, int each_CaseQuantity, string vend, string base_UnitOfMeasure)
        {
            Console.Write("This is a simulation of the item being saved to local database.\n" + "Item ID: " + item_ID + "\nItem Name: " + item_Name
                + "\nStorage Location: " + storage_Location + "\nCase Cost: " + cost_Case + "\nDepartment: " + dept + "\nCase Quantity in Stock: " 
                + case_QuantityInStock + "\nQuantity in a Full Case (each): " + each_CaseQuantity + "\nVendor: " + vend + "\nBase Unit of Measure: " + base_UnitOfMeasure);
        }
    }
}
