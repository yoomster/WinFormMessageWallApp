using MessageWallLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLibrary;

namespace WinFormMessageWall
{
    public partial class AddressForm : Form
    {
        ISaveAddress _parent; 

        public AddressForm(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        private void addAdressButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(streetNameText.Text) || string.IsNullOrWhiteSpace(houseNrText.Text) || string.IsNullOrWhiteSpace(postcodeText.Text) || string.IsNullOrWhiteSpace(cityText.Text) || string.IsNullOrWhiteSpace(countryText.Text))
            {
                MessageBox.Show("Incorrect entry, plz enter both names",
                    "Blank Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddressModel address = new AddressModel
                {
                    StreetName = streetNameText.Text,
                    HouseNr = houseNrText.Text,
                    PostCode = postcodeText.Text,
                    City = cityText.Text,
                    Country = countryText.Text
                };

                _parent.SaveAddres(address);

                this.Close();
            }
        }
    }
}
