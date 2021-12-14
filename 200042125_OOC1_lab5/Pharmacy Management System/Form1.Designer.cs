namespace Pharmacy_Management_System
{
    partial class Form1
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.companyTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSellTxt = new System.Windows.Forms.TextBox();
            this.quantitySellTxt = new System.Windows.Forms.TextBox();
            this.addSalesButton = new System.Windows.Forms.Button();
            this.nameStatusTxt = new System.Windows.Forms.TextBox();
            this.showStatusButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(30, 138);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(201, 22);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.Text = "NAME";
            // 
            // companyTxt
            // 
            this.companyTxt.Location = new System.Drawing.Point(30, 175);
            this.companyTxt.Name = "companyTxt";
            this.companyTxt.Size = new System.Drawing.Size(201, 22);
            this.companyTxt.TabIndex = 2;
            this.companyTxt.Text = "COMPANY";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(30, 215);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(201, 22);
            this.quantityTxt.TabIndex = 3;
            this.quantityTxt.Text = "QUANTITY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MEDICINE";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(30, 253);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(201, 22);
            this.priceTxt.TabIndex = 5;
            this.priceTxt.Text = "PRICE";
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Location = new System.Drawing.Point(30, 296);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(201, 23);
            this.addMedicineButton.TabIndex = 6;
            this.addMedicineButton.Text = "ADD MEDICINE";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.addMedicineButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "SELLING MEDICINE";
            // 
            // nameSellTxt
            // 
            this.nameSellTxt.Location = new System.Drawing.Point(30, 398);
            this.nameSellTxt.Name = "nameSellTxt";
            this.nameSellTxt.Size = new System.Drawing.Size(201, 22);
            this.nameSellTxt.TabIndex = 8;
            this.nameSellTxt.Text = "NAME";
            // 
            // quantitySellTxt
            // 
            this.quantitySellTxt.Location = new System.Drawing.Point(30, 435);
            this.quantitySellTxt.Name = "quantitySellTxt";
            this.quantitySellTxt.Size = new System.Drawing.Size(201, 22);
            this.quantitySellTxt.TabIndex = 9;
            this.quantitySellTxt.Text = "QUANTITY";
            // 
            // addSalesButton
            // 
            this.addSalesButton.Location = new System.Drawing.Point(30, 472);
            this.addSalesButton.Name = "addSalesButton";
            this.addSalesButton.Size = new System.Drawing.Size(201, 23);
            this.addSalesButton.TabIndex = 10;
            this.addSalesButton.Text = "ADD to SALES";
            this.addSalesButton.UseVisualStyleBackColor = true;
            this.addSalesButton.Click += new System.EventHandler(this.addSalesButton_Click);
            // 
            // nameStatusTxt
            // 
            this.nameStatusTxt.Location = new System.Drawing.Point(525, 152);
            this.nameStatusTxt.Name = "nameStatusTxt";
            this.nameStatusTxt.Size = new System.Drawing.Size(201, 22);
            this.nameStatusTxt.TabIndex = 11;
            this.nameStatusTxt.Text = "NAME";
            // 
            // showStatusButton
            // 
            this.showStatusButton.Location = new System.Drawing.Point(525, 190);
            this.showStatusButton.Name = "showStatusButton";
            this.showStatusButton.Size = new System.Drawing.Size(201, 23);
            this.showStatusButton.TabIndex = 12;
            this.showStatusButton.Text = "SHOW STATUS";
            this.showStatusButton.UseVisualStyleBackColor = true;
            this.showStatusButton.Click += new System.EventHandler(this.showStatusButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(356, 274);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(512, 244);
            this.listBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "PHARMACY MANAGEMENT SYSYTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "COMPANY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "STOCK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "ACCOUNTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 565);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.showStatusButton);
            this.Controls.Add(this.nameStatusTxt);
            this.Controls.Add(this.addSalesButton);
            this.Controls.Add(this.quantitySellTxt);
            this.Controls.Add(this.nameSellTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.companyTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox companyTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSellTxt;
        private System.Windows.Forms.TextBox quantitySellTxt;
        private System.Windows.Forms.Button addSalesButton;
        private System.Windows.Forms.TextBox nameStatusTxt;
        private System.Windows.Forms.Button showStatusButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

