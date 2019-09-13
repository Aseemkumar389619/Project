namespace CustomerInformationUi
{
    partial class customerInfo
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(71, 30);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(106, 13);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Customer Information";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(87, 63);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(82, 13);
            this.CustomerName.TabIndex = 1;
            this.CustomerName.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(230, 63);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.customerNameTextBox.TabIndex = 2;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(87, 99);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(61, 13);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "Contact No";
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(230, 99);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(209, 20);
            this.contactNoTextBox.TabIndex = 4;
            this.contactNoTextBox.TextChanged += new System.EventHandler(this.contactNoTextBox_TextChanged);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(87, 137);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Location = new System.Drawing.Point(87, 243);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(33, 13);
            this.Order.TabIndex = 6;
            this.Order.Text = "Order";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(87, 200);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Quantity";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(230, 298);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(230, 137);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(209, 20);
            this.addressTextBox.TabIndex = 10;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(544, 54);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(191, 254);
            this.showRichTextBox.TabIndex = 14;
            this.showRichTextBox.Text = "";
            this.showRichTextBox.TextChanged += new System.EventHandler(this.showRichTextBox_TextChanged);
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular",
            "None"});
            this.orderComboBox.Location = new System.Drawing.Point(230, 235);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(209, 21);
            this.orderComboBox.TabIndex = 15;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(230, 200);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(209, 20);
            this.quantityTextBox.TabIndex = 16;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // customerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.customerLabel);
            this.Name = "customerInfo";
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}

