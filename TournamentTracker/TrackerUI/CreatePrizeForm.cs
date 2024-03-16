using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {


            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameTxt.Text,
                    placeNumberTxt.Text,
                    prizeAmountTxt.Text,
                    prizePercentageTxt.Text);

                model = GlobalConfig.Connection.CreatePrize(model);



                placeNameTxt.Text = "";
                placeNumberTxt.Text = "";
                prizeAmountTxt.Text = "0";
                prizePercentageTxt.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information, please check and try again!");
            }

        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            if (!int.TryParse(placeNumberTxt.Text, out placeNumber) || placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTxt.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountTxt.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTxt.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 && prizePercentage < 100)
            {
                output = false;
            }


            return output;
        }
    }
}
