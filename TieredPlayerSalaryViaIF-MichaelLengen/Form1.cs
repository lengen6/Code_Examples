//Michael Lengen
//Student ID 225199
//Started on 3/10/21
//Goal: To make a program that calculates a tiered salary based on a player's hits and MVP/All Star status and keeps track of the leading player. The program will also validate the hit count entered

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieredPlayerSalaryViaIF_MichaelLengen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Input
        //Declare global variables
        string leaderName = "";
        decimal leaderHits = 0;
        decimal leaderTotalSalary = 0;
        decimal leaderTier = 0;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //Input
            //Declare variables
            decimal hits = 0;
            decimal tier = 0;
            decimal ratePerHit = 0;
            decimal baseSalary = 0;
            decimal mvpBonus = 0;
            decimal allStarBonus = 0;
            decimal totalSalary = 0;
            string currentName = "";
            bool myTryParse;

            //Validate user inputs
            currentName = playerNameTxt.Text;
            if(currentName.Length < 1)
            {
                MessageBox.Show("Player name is required");
                return;
            }

            myTryParse = decimal.TryParse(numberOfHitsTxt.Text, out hits);
            
            if(myTryParse == false)
            {
                MessageBox.Show("Please enter a numeric value for hits");
                return;
            }
            if(hits <= 0 || hits > 300 || hits % 1 != 0)
            {
                MessageBox.Show("Please enter a whole number between 1 and 300");
                return;
            }

            //Processing
            //Determine Player tier and rate per hit
            if(hits > 0 && hits <= 49)
            {
                tier = 1;
                ratePerHit = 17500;
            }
            else if (hits >= 50 && hits <= 99)
            {
                tier = 2;
                ratePerHit = 20000;
            }
            else if(hits >= 100 && hits <= 149)
            {
                tier = 3;
                ratePerHit = 22500;
            }
            else
            {
                tier = 4;
                ratePerHit = 25000;
            }

            //Calculate base salary, bonuses and total salary
            baseSalary = ((decimal)hits * ratePerHit);

            if(mvpCheck.Checked == true && allStarCheck.Checked == true)
            {
                mvpBonus = (decimal)((double)baseSalary * .25);
                bonusPayLbl.Text = "Bonus Pay MVP and All Star";
            }
            else if(mvpCheck.Checked == true || allStarCheck.Checked == true)
            {
                mvpBonus = (decimal)((double)baseSalary * .20);
                bonusPayLbl.Text = "Bonus Pay MVP or All Star";
            }

            totalSalary = baseSalary + mvpBonus;

            //Determine leader and update global variables
            if(hits > leaderHits)
            {
                leaderHits = hits;
                leaderName = currentName;
                leaderTier = tier;
                leaderTotalSalary = totalSalary;
            }

            //Output
            //Display current player stats
            tierResultLbl.Text = tier.ToString("n2");
            baseSalaryResultLbl.Text = baseSalary.ToString("c");
            mvpBonusResultLbl.Text = mvpBonus.ToString("c");
            totalSalaryResultLbl.Text = totalSalary.ToString("c");

            //Display Leader stats
            leadingNameResultLbl.Text = leaderName;
            leadingHitsResultsLbl.Text = leaderHits.ToString("n2");
            leadingSalaryResutlLbl.Text = leaderTotalSalary.ToString("c");
            leadingTierResultLbl.Text = leaderTier.ToString("n2");

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Clear global variables and dispaly fields
            leaderName = "";
            leaderHits = 0;
            leaderTotalSalary = 0;
            leaderTier = 0;

            tierResultLbl.Text = "";
            baseSalaryResultLbl.Text = "";
            mvpBonusResultLbl.Text = "";
            totalSalaryResultLbl.Text = "";

            leadingNameResultLbl.Text = "";
            leadingHitsResultsLbl.Text = "";
            leadingSalaryResutlLbl.Text = "";
            leadingTierResultLbl.Text = "";

            playerNameTxt.Text = "";
            numberOfHitsTxt.Text = "";
        }
    }
}
