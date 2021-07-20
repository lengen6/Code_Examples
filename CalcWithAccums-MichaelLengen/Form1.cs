//Michael Lengen
//Student ID 225199
//Started on 3/3/21
//Goal: To make a program that calcultes the cost of mulch by the cubic yard based on a user's input. It then tracks the totals for all orders and calculates how many orders can fit in a truck.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithAccums_MichaelLengen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Input
        //Initialize global variables
        decimal totalCubicFeet = 0;
        decimal numberOfOrders = 0;
        decimal cubicYardConversion = 27;
        decimal price = 17;
        decimal truckCapacity = 4;

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //Input
            //Take users input and assign them to variables
            decimal length = decimal.Parse(lengthTxt.Text);
            decimal width = decimal.Parse(widthTxt.Text);
            decimal depth = decimal.Parse(depthTxt.Text);

            //Processing
            //Calculate current order info
            decimal cubicFeet = length * width * depth;
            decimal cubicYards = cubicFeet / cubicYardConversion;
            decimal cost = cubicYards * price;

            //Sum Accumulator Variables
            totalCubicFeet = totalCubicFeet + cubicFeet;
            numberOfOrders = numberOfOrders + 1;

            //Calculate Accumlated Results
            decimal totalCubicYards = totalCubicFeet / cubicYardConversion;
            decimal totalCost = totalCubicYards * price;

            //Calculate truck capacity and space remaining
            decimal inTruck = totalCubicYards;
            decimal truckSpaceLeft = 4 - inTruck;
            decimal spaceInTruck = truckCapacity - totalCubicYards;

            //Change truck remaing background
            if(truckSpaceLeft <= 0)
            {
                remainingCapacityResult.BackColor = Color.Red;
            } else
            {
                remainingCapacityResult.BackColor = Color.Green;
            }


            //Output
            //Display Current order info
            cubicFtResult.Text = cubicFeet.ToString("n2");
            cubicYardsResult.Text = cubicYards.ToString("n2");
            costResult.Text = cost.ToString("c");

            //Display hidden text
            costLbl.Text = "@ " + price.ToString("c");
            truckCapacityInfo.Text = truckCapacity.ToString("n2");

            //Display Accummulator Totals
            cubicFtAllResult.Text = totalCubicFeet.ToString("n2");
            cubicYardsAllResult.Text = totalCubicYards.ToString("n2");
            costTotalResult.Text = totalCost.ToString("c");
            numberOrdersResult.Text = numberOfOrders.ToString("n0");
            lessResult.Text = totalCubicYards.ToString("n2");
            remainingCapacityResult.Text = spaceInTruck.ToString("n2");


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clear Logic
            //Set all labels and the input text boxes to blank
            lengthTxt.Text = "";
            widthTxt.Text = "";
            depthTxt.Text = "";


            cubicFtResult.Text = "";
            cubicYardsResult.Text = "";
            costResult.Text = "";
            cubicFtAllResult.Text = "";
            cubicYardsAllResult.Text = "";
            costTotalResult.Text = "";
            numberOrdersResult.Text = "";
            lessResult.Text = "";
            remainingCapacityResult.Text = "";

            //reset global variables
            totalCubicFeet = 0;
            numberOfOrders = 0;
            cubicYardConversion = 27;
            price = 17;
     
        }
    }
}
