using MessageWallLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLibrary;

namespace WinFormMessageWall
{
    public partial class WelcomeForm : Form, ISaveAddress
    {
        BindingList <AddressModel> addresses = new BindingList <AddressModel> ();

        public WelcomeForm()
        {
            InitializeComponent();

            addressListBox.DataSource = addresses;
            addressListBox.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(firstNameText.Text) || string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                MessageBox.Show("Incorrect entry, plz enter both names",
                    "Blank Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PersonModel person = new PersonModel
                {
                    FirstName = firstNameText.Text,
                    LastName = lastNameText.Text,
                    Addresses = addresses.ToList()
                };

                MessageBox.Show($"Hi, {firstNameText.Text} {lastNameText.Text}", "Welcome", MessageBoxButtons.OK);

                MessageForm form3 = new MessageForm();
                form3.Show();

            }
        }

        private void addAddressButton_Click(object sender, EventArgs e)
        {
            AddressForm addAddress = new AddressForm(this);

            addAddress.Show();
        }

        public void SaveAddres(AddressModel address)
        {
            addresses.Add(address);
        }
    }
}
