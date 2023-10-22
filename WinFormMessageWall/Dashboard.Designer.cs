namespace WinFormMessageWall
{
    partial class Dashboard
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageListBoxLabel = new System.Windows.Forms.Label();
            this.addMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(53, 30);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(83, 24);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(142, 30);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(248, 32);
            this.messageText.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 24;
            this.messageListBox.Location = new System.Drawing.Point(57, 111);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(333, 220);
            this.messageListBox.TabIndex = 3;
            // 
            // messageListBoxLabel
            // 
            this.messageListBoxLabel.AutoSize = true;
            this.messageListBoxLabel.Location = new System.Drawing.Point(53, 84);
            this.messageListBoxLabel.Name = "messageListBoxLabel";
            this.messageListBoxLabel.Size = new System.Drawing.Size(83, 24);
            this.messageListBoxLabel.TabIndex = 3;
            this.messageListBoxLabel.Text = "Message";
            // 
            // addMessage
            // 
            this.addMessage.Location = new System.Drawing.Point(396, 29);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(68, 32);
            this.addMessage.TabIndex = 2;
            this.addMessage.Text = "Add";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.addMessage_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 364);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.messageListBoxLabel);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label messageListBoxLabel;
        private System.Windows.Forms.Button addMessage;
    }
}

