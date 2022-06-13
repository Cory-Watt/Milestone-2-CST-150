namespace Milestone_Project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label2 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.activeCb = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.storageLocation = new System.Windows.Forms.ComboBox();
            this.itemID = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costCase = new System.Windows.Forms.TextBox();
            this.eachCaseQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.caseQuantityInStock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.eachQuantityInStock = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vendor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.baseUnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add/Edit Item";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.exitBtn.Location = new System.Drawing.Point(871, -3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(33, 38);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // activeCb
            // 
            this.activeCb.AutoSize = true;
            this.activeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.activeCb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.activeCb.Location = new System.Drawing.Point(762, 304);
            this.activeCb.Name = "activeCb";
            this.activeCb.Size = new System.Drawing.Size(65, 21);
            this.activeCb.TabIndex = 24;
            this.activeCb.Text = "Active";
            this.activeCb.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.saveBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.saveBtn.Location = new System.Drawing.Point(705, 379);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(151, 38);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // storageLocation
            // 
            this.storageLocation.FormattingEnabled = true;
            this.storageLocation.Location = new System.Drawing.Point(164, 181);
            this.storageLocation.Name = "storageLocation";
            this.storageLocation.Size = new System.Drawing.Size(181, 21);
            this.storageLocation.TabIndex = 31;
            // 
            // itemID
            // 
            this.itemID.Location = new System.Drawing.Point(164, 101);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(181, 20);
            this.itemID.TabIndex = 30;
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(164, 139);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(181, 20);
            this.itemName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Storage Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Item Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Item ID:";
            // 
            // costCase
            // 
            this.costCase.Location = new System.Drawing.Point(164, 222);
            this.costCase.Name = "costCase";
            this.costCase.Size = new System.Drawing.Size(181, 20);
            this.costCase.TabIndex = 36;
            // 
            // eachCaseQuantity
            // 
            this.eachCaseQuantity.Location = new System.Drawing.Point(647, 183);
            this.eachCaseQuantity.Name = "eachCaseQuantity";
            this.eachCaseQuantity.Size = new System.Drawing.Size(181, 20);
            this.eachCaseQuantity.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(434, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Broken Case (each):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(434, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quantity in Stock (case):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(13, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Cost (case):";
            // 
            // caseQuantityInStock
            // 
            this.caseQuantityInStock.Location = new System.Drawing.Point(646, 103);
            this.caseQuantityInStock.Name = "caseQuantityInStock";
            this.caseQuantityInStock.Size = new System.Drawing.Size(181, 20);
            this.caseQuantityInStock.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(434, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 22);
            this.label11.TabIndex = 43;
            this.label11.Text = "Case Quantity (each):";
            // 
            // eachQuantityInStock
            // 
            this.eachQuantityInStock.Location = new System.Drawing.Point(647, 141);
            this.eachQuantityInStock.Name = "eachQuantityInStock";
            this.eachQuantityInStock.Size = new System.Drawing.Size(181, 20);
            this.eachQuantityInStock.TabIndex = 44;
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(164, 265);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(181, 21);
            this.department.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(13, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 45;
            this.label8.Text = "Department:";
            // 
            // vendor
            // 
            this.vendor.FormattingEnabled = true;
            this.vendor.Location = new System.Drawing.Point(647, 223);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(181, 21);
            this.vendor.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(434, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "Vendor:";
            // 
            // baseUnitOfMeasure
            // 
            this.baseUnitOfMeasure.FormattingEnabled = true;
            this.baseUnitOfMeasure.Location = new System.Drawing.Point(647, 266);
            this.baseUnitOfMeasure.Name = "baseUnitOfMeasure";
            this.baseUnitOfMeasure.Size = new System.Drawing.Size(181, 21);
            this.baseUnitOfMeasure.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(434, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 22);
            this.label10.TabIndex = 49;
            this.label10.Text = "Base Unit:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(840, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 38);
            this.button1.TabIndex = 51;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelBtn.Location = new System.Drawing.Point(17, 379);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(151, 38);
            this.cancelBtn.TabIndex = 52;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(868, 429);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baseUnitOfMeasure);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vendor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.eachQuantityInStock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.caseQuantityInStock);
            this.Controls.Add(this.costCase);
            this.Controls.Add(this.eachCaseQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.storageLocation);
            this.Controls.Add(this.itemID);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.activeCb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(868, 429);
            this.MinimumSize = new System.Drawing.Size(868, 429);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.CheckBox activeCb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox storageLocation;
        private System.Windows.Forms.TextBox itemID;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costCase;
        private System.Windows.Forms.TextBox eachCaseQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox caseQuantityInStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox eachQuantityInStock;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox vendor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox baseUnitOfMeasure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelBtn;
    }
}