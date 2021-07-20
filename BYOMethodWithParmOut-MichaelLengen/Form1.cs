//Michael Lengen
//Student ID 225199
//Started on 4/19/21
//Goal: To make a program that calculates the relative cost of two colleges based on a variety of information provided by the user. The aim is to let prospective student make informed financial decisions when it comes to their education.
//Use a method to calculate one year fuel cost for both colleges

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCostComparison_MichaelLengen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Define method

        private void MichaelLengenMETHODCalcOneYearFuelCost(decimal inputDistanceFromCollege, decimal inputNumberofTrips, decimal inputMPG, decimal inputFuelCost, out decimal Out_OneYearFuelCost)
        {
            decimal localTotalDistance = inputDistanceFromCollege * inputNumberofTrips;
            decimal localGallons = localTotalDistance / inputMPG;
            Out_OneYearFuelCost = localGallons * inputFuelCost;
        }

        private void calculateBtn_Click(object sender, EventArgs e)

        {
            //Input
            //Initialize variables that will be used
            decimal fuelCostOne = 0;
            decimal fuelCostTwo = 0;
            decimal numberOfTripsOne = 0;
            decimal numberOfTripsTwo = 0;
            decimal distanceFromCollegeOne = 0;
            decimal distanceFromCollegeTwo = 0;
            decimal appCostOne = 0;
            decimal appCostTwo = 0;
            decimal tuitionOne = 0;
            decimal tuitionTwo = 0;
            decimal roomAnBoardOne = 0;
            decimal roomandBoardTwo = 0;
            decimal Mpg = 25;
            decimal costOfGas = 2.5m;
            bool tripsOne;
            bool tripsTwo;
            bool distanceOne;
            bool distanceTwo;
            bool myAppCostOne;
            bool MyAppCostTwo;
            bool myTuitionOne;
            bool myTuitionTwo;
            bool roomOne;
            bool roomTwo;


            //Take info from text boxes and store them in the appropriate variables with validation. The validation would be a prime candidate for its own method in a future life
            tripsOne = decimal.TryParse(college1OneWayTxt.Text, out numberOfTripsOne);
            if(tripsOne == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if(numberOfTripsOne < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }
            tripsTwo = decimal.TryParse(college2OneWayTxt.Text, out numberOfTripsTwo);
            if (tripsTwo == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (numberOfTripsTwo < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }

            distanceOne = decimal.TryParse(college1DistanceTxt.Text, out distanceFromCollegeOne);
            if (distanceOne == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (distanceFromCollegeOne < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }

            distanceTwo = decimal.TryParse(college2DistanceTxt.Text, out distanceFromCollegeTwo);
            if (distanceTwo == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (distanceFromCollegeTwo < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }

            myAppCostOne = decimal.TryParse(college1AppFeeTxt.Text, out appCostOne);
            if (myAppCostOne == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (appCostOne < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }
            MyAppCostTwo = decimal.TryParse(college2AppFeeTxt.Text, out appCostTwo);
            if (MyAppCostTwo == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (appCostTwo < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }
            myTuitionOne = decimal.TryParse(college1TuitionTxt.Text, out tuitionOne);
            if (myTuitionOne == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (tuitionOne < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }
            myTuitionTwo = decimal.TryParse(college2TuitionTxt.Text, out tuitionTwo);
            if (myTuitionTwo == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (tuitionTwo < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }
            roomOne = decimal.TryParse(college1RoomTxt.Text, out roomAnBoardOne);
            if (roomOne == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (roomAnBoardOne < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }
            roomTwo = decimal.TryParse(college2RoomTxt.Text, out roomandBoardTwo);
            if (roomTwo == false)
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }
            if (roomandBoardTwo < 0)
            {
                MessageBox.Show("Number cannot be negative.");
                return;
            }

            //Processing
            //Calculate total fuel cost by multiplying distance traveled by trips then divide by miles per gallon and finally multiplying by fuel cost using a method

            MichaelLengenMETHODCalcOneYearFuelCost(distanceFromCollegeOne, numberOfTripsOne, Mpg, costOfGas, out fuelCostOne);
            MichaelLengenMETHODCalcOneYearFuelCost(distanceFromCollegeTwo, numberOfTripsTwo, Mpg, costOfGas, out fuelCostTwo);

            //Calculate the total annual cost by adding up total fuel cost, room and board, and tuiton then multiplying them by 4 then adding in the application fee
            decimal degreeCostOne = 4 * (fuelCostOne + tuitionOne + roomAnBoardOne) + appCostOne;
            decimal degreeCostTwo = 4 * (fuelCostTwo + tuitionTwo + roomandBoardTwo) + appCostTwo;

            //Output
            //Display the relevant values calculated above
            college1FuelCostLbl.Text = fuelCostOne.ToString("c");
            college2FuelCostLbl.Text = fuelCostTwo.ToString("c");
            college1TotalCostLbl.Text = degreeCostOne.ToString("c");
            college2TotalCostLbl.Text = degreeCostTwo.ToString("c");


            //Turn the higher costed college's lable red or turn both blue if equal
            if(degreeCostOne > degreeCostTwo)
            {
                college1TotalCostLbl.BackColor = Color.Red;
            } else if(degreeCostOne < degreeCostTwo){
                college2TotalCostLbl.BackColor = Color.Red;
            } else
            {
                college1TotalCostLbl.BackColor = Color.Blue;
                college2TotalCostLbl.BackColor = Color.Blue;
            }
        }
    }
}
