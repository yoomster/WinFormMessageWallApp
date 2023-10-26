namespace WinFormMessageWall
{
    partial class WelcomeForm
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
            this.components = new System.ComponentModel.Container();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.welcomeText = new System.Windows.Forms.TextBox();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.addressListBox = new System.Windows.Forms.ListBox();
            this.addressModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addressModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.firstNameLabel.Location = new System.Drawing.Point(34, 160);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(104, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.lastNameLabel.Location = new System.Drawing.Point(34, 203);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(103, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.confirmButton.Location = new System.Drawing.Point(486, 413);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(135, 55);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.firstNameText.Location = new System.Drawing.Point(148, 160);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(191, 32);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.lastNameText.Location = new System.Drawing.Point(147, 203);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(191, 32);
            this.lastNameText.TabIndex = 2;
            // 
            // welcomeText
            // 
            this.welcomeText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.welcomeText.Location = new System.Drawing.Point(33, 24);
            this.welcomeText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(460, 32);
            this.welcomeText.TabIndex = 9;
            this.welcomeText.TabStop = false;
            this.welcomeText.Text = "Hey there! Thank you for using Message Wall!";
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Location = new System.Drawing.Point(34, 106);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(232, 24);
            this.IntroLabel.TabIndex = 6;
            this.IntroLabel.Text = "Who is joining us today?";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.addressLabel.Location = new System.Drawing.Point(34, 247);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(76, 24);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // addAddressButton
            // 
            this.addAddressButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddressButton.Location = new System.Drawing.Point(397, 201);
            this.addAddressButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(147, 37);
            this.addAddressButton.TabIndex = 3;
            this.addAddressButton.Text = "Add new address";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // addressListBox
            // 
            this.addressListBox.FormattingEnabled = true;
            this.addressListBox.HorizontalScrollbar = true;
            this.addressListBox.ItemHeight = 24;
            this.addressListBox.Location = new System.Drawing.Point(148, 247);
            this.addressListBox.MultiColumn = true;
            this.addressListBox.Name = "addressListBox";
            this.addressListBox.Size = new System.Drawing.Size(396, 148);
            this.addressListBox.TabIndex = 13;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 483);
            this.Controls.Add(this.addressListBox);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.addressModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox welcomeText;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.ListBox addressListBox;
        private System.Windows.Forms.BindingSource addressModelBindingSource;
    }
}