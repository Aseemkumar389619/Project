namespace personalIformation
{
    partial class Information
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
            this.Personalinfo = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.motherNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllInformation = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parentButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Personalinfo
            // 
            this.Personalinfo.Location = new System.Drawing.Point(285, 25);
            this.Personalinfo.Name = "Personalinfo";
            this.Personalinfo.Size = new System.Drawing.Size(140, 26);
            this.Personalinfo.TabIndex = 0;
            this.Personalinfo.Text = "Personal Informatin";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(127, 67);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(127, 105);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Location = new System.Drawing.Point(127, 143);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(68, 13);
            this.fatherNameLabel.TabIndex = 3;
            this.fatherNameLabel.Text = "Father Name";
            // 
            // motherNameLabel
            // 
            this.motherNameLabel.AutoSize = true;
            this.motherNameLabel.Location = new System.Drawing.Point(127, 178);
            this.motherNameLabel.Name = "motherNameLabel";
            this.motherNameLabel.Size = new System.Drawing.Size(71, 13);
            this.motherNameLabel.TabIndex = 4;
            this.motherNameLabel.Text = "Mother Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(127, 211);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(279, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(279, 98);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(279, 140);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.fatherNameTextBox.TabIndex = 8;
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(279, 171);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.motherNameTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(279, 211);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(111, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(190, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllInformation
            // 
            this.showAllInformation.Location = new System.Drawing.Point(340, 275);
            this.showAllInformation.Name = "showAllInformation";
            this.showAllInformation.Size = new System.Drawing.Size(148, 23);
            this.showAllInformation.TabIndex = 12;
            this.showAllInformation.Text = "Show All Informatin";
            this.showAllInformation.UseVisualStyleBackColor = true;
            this.showAllInformation.Click += new System.EventHandler(this.showAllInformation_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(190, 333);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 13;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // parentButton
            // 
            this.parentButton.Location = new System.Drawing.Point(340, 332);
            this.parentButton.Name = "parentButton";
            this.parentButton.Size = new System.Drawing.Size(107, 23);
            this.parentButton.TabIndex = 14;
            this.parentButton.Text = "Parent Name";
            this.parentButton.UseVisualStyleBackColor = true;
            this.parentButton.Click += new System.EventHandler(this.parentButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(482, 332);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 23);
            this.addressButton.TabIndex = 15;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parentButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.showAllInformation);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.motherNameLabel);
            this.Controls.Add(this.fatherNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.Personalinfo);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Personalinfo;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label motherNameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllInformation;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parentButton;
        private System.Windows.Forms.Button addressButton;
    }
}

