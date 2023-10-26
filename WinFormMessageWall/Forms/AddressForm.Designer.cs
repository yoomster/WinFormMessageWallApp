namespace WinFormMessageWall
{
    partial class AddressForm
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
            this.addAdressButton = new System.Windows.Forms.Button();
            this.streetNameLabel = new System.Windows.Forms.Label();
            this.streetNameText = new System.Windows.Forms.TextBox();
            this.houseNrText = new System.Windows.Forms.TextBox();
            this.houseNrLabel = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postcodeText = new System.Windows.Forms.TextBox();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addAdressButton
            // 
            this.addAdressButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.addAdressButton.Location = new System.Drawing.Point(505, 241);
            this.addAdressButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addAdressButton.Name = "addAdressButton";
            this.addAdressButton.Size = new System.Drawing.Size(183, 57);
            this.addAdressButton.TabIndex = 6;
            this.addAdressButton.Text = "Add Address";
            this.addAdressButton.UseVisualStyleBackColor = true;
            this.addAdressButton.Click += new System.EventHandler(this.addAdressButton_Click);
            // 
            // streetNameLabel
            // 
            this.streetNameLabel.AutoSize = true;
            this.streetNameLabel.Location = new System.Drawing.Point(76, 44);
            this.streetNameLabel.Name = "streetNameLabel";
            this.streetNameLabel.Size = new System.Drawing.Size(114, 24);
            this.streetNameLabel.TabIndex = 10;
            this.streetNameLabel.Text = "Street name";
            // 
            // streetNameText
            // 
            this.streetNameText.Location = new System.Drawing.Point(196, 36);
            this.streetNameText.Name = "streetNameText";
            this.streetNameText.Size = new System.Drawing.Size(193, 32);
            this.streetNameText.TabIndex = 1;
            // 
            // houseNrText
            // 
            this.houseNrText.Location = new System.Drawing.Point(196, 82);
            this.houseNrText.Name = "houseNrText";
            this.houseNrText.Size = new System.Drawing.Size(193, 32);
            this.houseNrText.TabIndex = 2;
            // 
            // houseNrLabel
            // 
            this.houseNrLabel.AutoSize = true;
            this.houseNrLabel.Location = new System.Drawing.Point(56, 90);
            this.houseNrLabel.Name = "houseNrLabel";
            this.houseNrLabel.Size = new System.Drawing.Size(134, 24);
            this.houseNrLabel.TabIndex = 11;
            this.houseNrLabel.Text = "House number";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(196, 182);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(193, 32);
            this.cityText.TabIndex = 4;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(149, 190);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(41, 24);
            this.cityLabel.TabIndex = 12;
            this.cityLabel.Text = "City";
            // 
            // countryText
            // 
            this.countryText.Location = new System.Drawing.Point(196, 233);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(193, 32);
            this.countryText.TabIndex = 5;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(117, 241);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(73, 24);
            this.countryLabel.TabIndex = 13;
            this.countryLabel.Text = "Country";
            // 
            // postcodeText
            // 
            this.postcodeText.Location = new System.Drawing.Point(196, 134);
            this.postcodeText.Name = "postcodeText";
            this.postcodeText.Size = new System.Drawing.Size(193, 32);
            this.postcodeText.TabIndex = 3;
            // 
            // postcodeLabel
            // 
            this.postcodeLabel.AutoSize = true;
            this.postcodeLabel.Location = new System.Drawing.Point(105, 142);
            this.postcodeLabel.Name = "postcodeLabel";
            this.postcodeLabel.Size = new System.Drawing.Size(85, 24);
            this.postcodeLabel.TabIndex = 11;
            this.postcodeLabel.Text = "Postcode";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 309);
            this.Controls.Add(this.postcodeText);
            this.Controls.Add(this.postcodeLabel);
            this.Controls.Add(this.countryText);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.houseNrText);
            this.Controls.Add(this.houseNrLabel);
            this.Controls.Add(this.streetNameText);
            this.Controls.Add(this.streetNameLabel);
            this.Controls.Add(this.addAdressButton);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddressForm";
            this.Text = "Add a new address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addAdressButton;
        private System.Windows.Forms.Label streetNameLabel;
        private System.Windows.Forms.TextBox streetNameText;
        private System.Windows.Forms.TextBox houseNrText;
        private System.Windows.Forms.Label houseNrLabel;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox postcodeText;
        private System.Windows.Forms.Label postcodeLabel;
    }
}