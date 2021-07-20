//Michael Lengen
//Student ID 225199
//Started on 4/28/21
//Goal: To make a program where a user can enter students' names and grades and it will display them in along with an average and total number of students. It will use arrays to stroe the data


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOfStudents_MichaelLengen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Input
        //Declare global variables and arrays

        string[] studentArray = new string[5];
        int[] gradeArray = new int[5];
        const int maxSize = 5;
        int studentCount = 0;
        int arrayIndexPosition = 0;


        private void addToArrayBtn_Click(object sender, EventArgs e)
        {
            //Input
            //Declare local variables
            bool myNumberBool ;
            string studentName = "";
            int studentGrade = 0;

            //Validation that a name was entered and that the student grade was entered, an integer, 0 or greater, and less than 100
            if (nameTxt.Text == "")
            {
                MessageBox.Show("Please enter a student name");
                    return;
            }
            else
            {
                studentName = nameTxt.Text;
            }

            myNumberBool = int.TryParse(gradeTxt.Text, out studentGrade);
            if(myNumberBool == false)
            {
                MessageBox.Show("Please enter a whole number for student grade");
                return;
            }
            else if(studentGrade < 0)
            {
                MessageBox.Show("Student grade must be 0 or greater");
                return;
            }
            else if(studentGrade > 100)
            {
                MessageBox.Show("Student grade cannot be greater than 100");
                return;
            }

            //Add student name and grade to array
            if(arrayIndexPosition >= maxSize)
            {
                MessageBox.Show("Array is full either display the array to view current contents or clear it to enter new information");
                return;
            }
            else
            {
                studentArray[arrayIndexPosition] = studentName;
                gradeArray[arrayIndexPosition] = studentGrade;

            }
            //Increment tracking variable and display a confirmation message with the index position

            MessageBox.Show("Student added to array at index position [" + arrayIndexPosition + "].");

            arrayIndexPosition += 1;
            studentCount += 1;
            nameTxt.Text = "";
            gradeTxt.Text = "";

        }

        private void displayArrayBtn_Click(object sender, EventArgs e)
        {
            //Input cont. Declare display variable

            string myString = "Student Data Entered So Far: \n";
            int studentCount = 0;
            decimal totalScore = 0;
            decimal avgScore = 0;

            //Processing
            //Calculate Average and build display string from array

            for (int i = 0; i < studentArray.Length; i++)
            {
                myString +=
                    "Array[" + i + "]  ==>  " +
                    "Student #" + (i + 1);

                if (gradeArray[i] == 0)
                {
                    myString += "     (Not Entered)";
                }
                else
                {
                    myString +=
                        "    Name:" + studentArray[i] +
                        "    Grade:" + gradeArray[i];
                    totalScore += gradeArray[i];
                    studentCount++;
                }
                myString += "\n";
            }

            if(studentCount > 0)
            {
                avgScore = totalScore / studentCount;
                myString += "Total Students: " + studentCount +
                    "     Average Score: " + avgScore.ToString("n2");

            }

            //Output
            //Display the string built above

            displayLbl.Text = myString;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //Reset global variables and clear display
            Array.Clear(studentArray, 0, studentArray.Length);
            Array.Clear(gradeArray, 0, gradeArray.Length);
            studentCount = 0;
            arrayIndexPosition = 0;
            displayLbl.Text = "";
        }
    }
}
