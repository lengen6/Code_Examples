//Michael Lengen
//Student ID 225199
//Started on 3/17/21
//Goal: To make a program that calculates tiered shipping weights based on weight and shipping zone. Use radio buttons for shipping zones.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingCalculator_MichaelLengen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //Input
            //Declare variables
            decimal pkgWeight = 0;
            string pkgZone = "";
            bool myTryParse;
            decimal weightCost = 0;
            decimal totalCost = 0;
            decimal pricePerPound = 0;
            decimal zonePrice = 0;

            //Clear old display values
            pkgWeightCostResult.Text = "";
            pkgZoneCostResult.Text = "";
            pkgTotalCostResult.Text = "";
            costPerWeightResult.Text = "";
            capResult.Text = "";


            //Validate user input
            
            myTryParse = decimal.TryParse(pkgWeightTxt.Text, out pkgWeight);

            if (myTryParse == false)
            {
                MessageBox.Show("Please enter a numeric value for weight");
                return;
            }
            if(pkgWeight <= 0)
            {
                MessageBox.Show("Please enter a positive number for length");
                return;
            }

            //Determine zone
            if(radioN.Checked == true)
            {
                zonePrice = 27;
            }else if(radioS.Checked == true)
            {
                zonePrice = 36;
            }else if(radioE.Checked == true)
            {
                zonePrice = 45;
            }else if(radioW.Checked == true)
            {
                zonePrice = 54;
            }else
            {
                MessageBox.Show("Please select a shipping zone from the options to the right");
                return;
            }

            //Processing
            //Calculate weight cost
            weightCost = pkgWeight * 18;

            //Calculate total cost
            totalCost = weightCost + zonePrice;

            //Cap price logic
            if(totalCost >= 100)
            {
                totalCost = 100;
            }

            //Calculate price per pound
            pricePerPound = totalCost / pkgWeight;

            //Output
            //Display results
            pkgWeightCostResult.Text = weightCost.ToString("c");
            pkgZoneCostResult.Text = zonePrice.ToString("c");
            pkgTotalCostResult.Text = totalCost.ToString("c");
            costPerWeightResult.Text = pricePerPound.ToString("c");
            if(totalCost >= 100)
            {
                capResult.Text = "CAPPED";
            }

            //Clear old values

        }
    }
}
