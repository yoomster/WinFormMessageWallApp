using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource= messages;
        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Incorrect entry, plz enter a message to add to the list",
                    "Black Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }

            messageText.Focus();

        }
    }
}
