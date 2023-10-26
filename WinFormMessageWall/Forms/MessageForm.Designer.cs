namespace WinFormMessageWall
{
    partial class MessageForm
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
            this.addMessageButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addMessageButton
            // 
            this.addMessageButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.addMessageButton.Location = new System.Drawing.Point(423, 107);
            this.addMessageButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addMessageButton.Name = "addMessageButton";
            this.addMessageButton.Size = new System.Drawing.Size(174, 45);
            this.addMessageButton.TabIndex = 2;
            this.addMessageButton.Text = "Add Message";
            this.addMessageButton.UseVisualStyleBackColor = true;
            this.addMessageButton.Click += new System.EventHandler(this.addMessageButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.messageLabel.Location = new System.Drawing.Point(91, 63);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(89, 24);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message:";
            // 
            // messageListBox
            // 
            this.messageListBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 24;
            this.messageListBox.Location = new System.Drawing.Point(95, 227);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(502, 388);
            this.messageListBox.TabIndex = 3;
            // 
            // messageText
            // 
            this.messageText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.messageText.Location = new System.Drawing.Point(184, 63);
            this.messageText.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(413, 32);
            this.messageText.TabIndex = 1;
            // 
            // messageBoxLabel
            // 
            this.messageBoxLabel.AutoSize = true;
            this.messageBoxLabel.Location = new System.Drawing.Point(91, 191);
            this.messageBoxLabel.Name = "messageBoxLabel";
            this.messageBoxLabel.Size = new System.Drawing.Size(92, 24);
            this.messageBoxLabel.TabIndex = 4;
            this.messageBoxLabel.Text = "Messages";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 675);
            this.Controls.Add(this.messageBoxLabel);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.addMessageButton);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MessageForm";
            this.Text = "Message Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMessageButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.Label messageBoxLabel;
    }
}