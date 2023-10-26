using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormMessageWall
{
    public partial class MessageForm : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public MessageForm()
        {
            InitializeComponent();
            WireUpMessages();
        }

        private void WireUpMessages()
        {
            messageListBox.DataSource = messages;

        }

        private void addMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Incorrect entry, enter a message to add to the list", "Blank Field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }
            messageText.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (messageListBox.SelectedItem != null)
            {
                // Remove the selected item from the ListBox
                messages.Remove(messageListBox.SelectedItem.ToString());
                // Refresh the ListBox to reflect the changes
                messageListBox.Refresh();
            }
        }
    }
}
