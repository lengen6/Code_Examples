
namespace CollegeCostComparison_MichaelLengen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.collegeNameLbl = new System.Windows.Forms.Label();
            this.collegeStateLbl = new System.Windows.Forms.Label();
            this.college1Lbl = new System.Windows.Forms.Label();
            this.college2Lbl = new System.Windows.Forms.Label();
            this.collegeTripsLbl = new System.Windows.Forms.Label();
            this.collegeDistanceLbl = new System.Windows.Forms.Label();
            this.collegeApplicationLbl = new System.Windows.Forms.Label();
            this.collegeTuitionLbl = new System.Windows.Forms.Label();
            this.collegeRoomLbl = new System.Windows.Forms.Label();
            this.college1NameTxt = new System.Windows.Forms.TextBox();
            this.college2NameTxt = new System.Windows.Forms.TextBox();
            this.college1StateTxt = new System.Windows.Forms.TextBox();
            this.college2StateTxt = new System.Windows.Forms.TextBox();
            this.college1OneWayTxt = new System.Windows.Forms.TextBox();
            this.college2OneWayTxt = new System.Windows.Forms.TextBox();
            this.college1DistanceTxt = new System.Windows.Forms.TextBox();
            this.college2DistanceTxt = new System.Windows.Forms.TextBox();
            this.college1AppFeeTxt = new System.Windows.Forms.TextBox();
            this.college2AppFeeTxt = new System.Windows.Forms.TextBox();
            this.college1TuitionTxt = new System.Windows.Forms.TextBox();
            this.college2TuitionTxt = new System.Windows.Forms.TextBox();
            this.college1RoomTxt = new System.Windows.Forms.TextBox();
            this.college2RoomTxt = new System.Windows.Forms.TextBox();
            this.CalculationsLbl = new System.Windows.Forms.Label();
            this.yearFuelCostLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.college1FuelCostLbl = new System.Windows.Forms.Label();
            this.college2FuelCostLbl = new System.Windows.Forms.Label();
            this.college1TotalCostLbl = new System.Windows.Forms.Label();
            this.college2TotalCostLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collegeNameLbl
            // 
            this.collegeNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeNameLbl.Location = new System.Drawing.Point(13, 67);
            this.collegeNameLbl.Name = "collegeNameLbl";
            this.collegeNameLbl.Size = new System.Drawing.Size(100, 23);
            this.collegeNameLbl.TabIndex = 0;
            this.collegeNameLbl.Text = "College Name";
            this.collegeNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collegeStateLbl
            // 
            this.collegeStateLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeStateLbl.Location = new System.Drawing.Point(13, 117);
            this.collegeStateLbl.Name = "collegeStateLbl";
            this.collegeStateLbl.Size = new System.Drawing.Size(100, 32);
            this.collegeStateLbl.TabIndex = 1;
            this.collegeStateLbl.Text = "State College is Located";
            this.collegeStateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.collegeStateLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // college1Lbl
            // 
            this.college1Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.college1Lbl.Location = new System.Drawing.Point(181, 9);
            this.college1Lbl.Name = "college1Lbl";
            this.college1Lbl.Size = new System.Drawing.Size(100, 23);
            this.college1Lbl.TabIndex = 2;
            this.college1Lbl.Text = "College 1";
            this.college1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // college2Lbl
            // 
            this.college2Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.college2Lbl.Location = new System.Drawing.Point(340, 9);
            this.college2Lbl.Name = "college2Lbl";
            this.college2Lbl.Size = new System.Drawing.Size(100, 23);
            this.college2Lbl.TabIndex = 3;
            this.college2Lbl.Text = "College 2";
            this.college2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collegeTripsLbl
            // 
            this.collegeTripsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeTripsLbl.Location = new System.Drawing.Point(12, 168);
            this.collegeTripsLbl.Name = "collegeTripsLbl";
            this.collegeTripsLbl.Size = new System.Drawing.Size(101, 40);
            this.collegeTripsLbl.TabIndex = 4;
            this.collegeTripsLbl.Text = "Number of 1 Way Trips Per Year";
            this.collegeTripsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collegeDistanceLbl
            // 
            this.collegeDistanceLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeDistanceLbl.Location = new System.Drawing.Point(13, 237);
            this.collegeDistanceLbl.Name = "collegeDistanceLbl";
            this.collegeDistanceLbl.Size = new System.Drawing.Size(100, 45);
            this.collegeDistanceLbl.TabIndex = 5;
            this.collegeDistanceLbl.Text = "One Way Distance from Home to College";
            this.collegeDistanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collegeApplicationLbl
            // 
            this.collegeApplicationLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeApplicationLbl.Location = new System.Drawing.Point(12, 299);
            this.collegeApplicationLbl.Name = "collegeApplicationLbl";
            this.collegeApplicationLbl.Size = new System.Drawing.Size(100, 35);
            this.collegeApplicationLbl.TabIndex = 6;
            this.collegeApplicationLbl.Text = "One Time Application Fee";
            this.collegeApplicationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collegeTuitionLbl
            // 
            this.collegeTuitionLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeTuitionLbl.Location = new System.Drawing.Point(12, 357);
            this.collegeTuitionLbl.Name = "collegeTuitionLbl";
            this.collegeTuitionLbl.Size = new System.Drawing.Size(100, 23);
            this.collegeTuitionLbl.TabIndex = 7;
            this.collegeTuitionLbl.Text = "Annual Tuition";
            this.collegeTuitionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collegeRoomLbl
            // 
            this.collegeRoomLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.collegeRoomLbl.Location = new System.Drawing.Point(13, 401);
            this.collegeRoomLbl.Name = "collegeRoomLbl";
            this.collegeRoomLbl.Size = new System.Drawing.Size(100, 23);
            this.collegeRoomLbl.TabIndex = 8;
            this.collegeRoomLbl.Text = "Annual Room & Board";
            this.collegeRoomLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // college1NameTxt
            // 
            this.college1NameTxt.Location = new System.Drawing.Point(181, 69);
            this.college1NameTxt.Name = "college1NameTxt";
            this.college1NameTxt.Size = new System.Drawing.Size(100, 20);
            this.college1NameTxt.TabIndex = 9;
            // 
            // college2NameTxt
            // 
            this.college2NameTxt.Location = new System.Drawing.Point(340, 70);
            this.college2NameTxt.Name = "college2NameTxt";
            this.college2NameTxt.Size = new System.Drawing.Size(100, 20);
            this.college2NameTxt.TabIndex = 10;
            // 
            // college1StateTxt
            // 
            this.college1StateTxt.Location = new System.Drawing.Point(181, 117);
            this.college1StateTxt.Name = "college1StateTxt";
            this.college1StateTxt.Size = new System.Drawing.Size(100, 20);
            this.college1StateTxt.TabIndex = 11;
            // 
            // college2StateTxt
            // 
            this.college2StateTxt.Location = new System.Drawing.Point(340, 117);
            this.college2StateTxt.Name = "college2StateTxt";
            this.college2StateTxt.Size = new System.Drawing.Size(100, 20);
            this.college2StateTxt.TabIndex = 12;
            // 
            // college1OneWayTxt
            // 
            this.college1OneWayTxt.Location = new System.Drawing.Point(181, 179);
            this.college1OneWayTxt.Name = "college1OneWayTxt";
            this.college1OneWayTxt.Size = new System.Drawing.Size(100, 20);
            this.college1OneWayTxt.TabIndex = 13;
            // 
            // college2OneWayTxt
            // 
            this.college2OneWayTxt.Location = new System.Drawing.Point(340, 179);
            this.college2OneWayTxt.Name = "college2OneWayTxt";
            this.college2OneWayTxt.Size = new System.Drawing.Size(100, 20);
            this.college2OneWayTxt.TabIndex = 14;
            // 
            // college1DistanceTxt
            // 
            this.college1DistanceTxt.Location = new System.Drawing.Point(181, 250);
            this.college1DistanceTxt.Name = "college1DistanceTxt";
            this.college1DistanceTxt.Size = new System.Drawing.Size(100, 20);
            this.college1DistanceTxt.TabIndex = 15;
            // 
            // college2DistanceTxt
            // 
            this.college2DistanceTxt.Location = new System.Drawing.Point(340, 250);
            this.college2DistanceTxt.Name = "college2DistanceTxt";
            this.college2DistanceTxt.Size = new System.Drawing.Size(100, 20);
            this.college2DistanceTxt.TabIndex = 16;
            // 
            // college1AppFeeTxt
            // 
            this.college1AppFeeTxt.Location = new System.Drawing.Point(181, 307);
            this.college1AppFeeTxt.Name = "college1AppFeeTxt";
            this.college1AppFeeTxt.Size = new System.Drawing.Size(100, 20);
            this.college1AppFeeTxt.TabIndex = 17;
            // 
            // college2AppFeeTxt
            // 
            this.college2AppFeeTxt.Location = new System.Drawing.Point(340, 307);
            this.college2AppFeeTxt.Name = "college2AppFeeTxt";
            this.college2AppFeeTxt.Size = new System.Drawing.Size(100, 20);
            this.college2AppFeeTxt.TabIndex = 18;
            // 
            // college1TuitionTxt
            // 
            this.college1TuitionTxt.Location = new System.Drawing.Point(181, 359);
            this.college1TuitionTxt.Name = "college1TuitionTxt";
            this.college1TuitionTxt.Size = new System.Drawing.Size(100, 20);
            this.college1TuitionTxt.TabIndex = 19;
            // 
            // college2TuitionTxt
            // 
            this.college2TuitionTxt.Location = new System.Drawing.Point(340, 359);
            this.college2TuitionTxt.Name = "college2TuitionTxt";
            this.college2TuitionTxt.Size = new System.Drawing.Size(100, 20);
            this.college2TuitionTxt.TabIndex = 20;
            // 
            // college1RoomTxt
            // 
            this.college1RoomTxt.Location = new System.Drawing.Point(181, 401);
            this.college1RoomTxt.Name = "college1RoomTxt";
            this.college1RoomTxt.Size = new System.Drawing.Size(100, 20);
            this.college1RoomTxt.TabIndex = 21;
            // 
            // college2RoomTxt
            // 
            this.college2RoomTxt.Location = new System.Drawing.Point(340, 404);
            this.college2RoomTxt.Name = "college2RoomTxt";
            this.college2RoomTxt.Size = new System.Drawing.Size(100, 20);
            this.college2RoomTxt.TabIndex = 22;
            // 
            // CalculationsLbl
            // 
            this.CalculationsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalculationsLbl.Location = new System.Drawing.Point(13, 439);
            this.CalculationsLbl.Name = "CalculationsLbl";
            this.CalculationsLbl.Size = new System.Drawing.Size(427, 35);
            this.CalculationsLbl.TabIndex = 23;
            this.CalculationsLbl.Text = "Calculations";
            this.CalculationsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearFuelCostLbl
            // 
            this.yearFuelCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearFuelCostLbl.Location = new System.Drawing.Point(25, 525);
            this.yearFuelCostLbl.Name = "yearFuelCostLbl";
            this.yearFuelCostLbl.Size = new System.Drawing.Size(100, 35);
            this.yearFuelCostLbl.TabIndex = 24;
            this.yearFuelCostLbl.Text = "Calculated Annual Fuel Cost\r\n";
            this.yearFuelCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostLbl.Location = new System.Drawing.Point(25, 586);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(100, 35);
            this.totalCostLbl.TabIndex = 25;
            this.totalCostLbl.Text = "Calculated 4 Year Total Cost\r\n";
            this.totalCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // college1FuelCostLbl
            // 
            this.college1FuelCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.college1FuelCostLbl.Location = new System.Drawing.Point(172, 531);
            this.college1FuelCostLbl.Name = "college1FuelCostLbl";
            this.college1FuelCostLbl.Size = new System.Drawing.Size(100, 23);
            this.college1FuelCostLbl.TabIndex = 26;
            this.college1FuelCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // college2FuelCostLbl
            // 
            this.college2FuelCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.college2FuelCostLbl.Location = new System.Drawing.Point(340, 531);
            this.college2FuelCostLbl.Name = "college2FuelCostLbl";
            this.college2FuelCostLbl.Size = new System.Drawing.Size(100, 23);
            this.college2FuelCostLbl.TabIndex = 27;
            this.college2FuelCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // college1TotalCostLbl
            // 
            this.college1TotalCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.college1TotalCostLbl.Location = new System.Drawing.Point(172, 592);
            this.college1TotalCostLbl.Name = "college1TotalCostLbl";
            this.college1TotalCostLbl.Size = new System.Drawing.Size(100, 23);
            this.college1TotalCostLbl.TabIndex = 28;
            this.college1TotalCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // college2TotalCostLbl
            // 
            this.college2TotalCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.college2TotalCostLbl.Location = new System.Drawing.Point(340, 592);
            this.college2TotalCostLbl.Name = "college2TotalCostLbl";
            this.college2TotalCostLbl.Size = new System.Drawing.Size(100, 23);
            this.college2TotalCostLbl.TabIndex = 29;
            this.college2TotalCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(12, 477);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(428, 23);
            this.calculateBtn.TabIndex = 30;
            this.calculateBtn.Text = "Calculate Totals for Both Colleges";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 653);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.college2TotalCostLbl);
            this.Controls.Add(this.college1TotalCostLbl);
            this.Controls.Add(this.college2FuelCostLbl);
            this.Controls.Add(this.college1FuelCostLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.yearFuelCostLbl);
            this.Controls.Add(this.CalculationsLbl);
            this.Controls.Add(this.college2RoomTxt);
            this.Controls.Add(this.college1RoomTxt);
            this.Controls.Add(this.college2TuitionTxt);
            this.Controls.Add(this.college1TuitionTxt);
            this.Controls.Add(this.college2AppFeeTxt);
            this.Controls.Add(this.college1AppFeeTxt);
            this.Controls.Add(this.college2DistanceTxt);
            this.Controls.Add(this.college1DistanceTxt);
            this.Controls.Add(this.college2OneWayTxt);
            this.Controls.Add(this.college1OneWayTxt);
            this.Controls.Add(this.college2StateTxt);
            this.Controls.Add(this.college1StateTxt);
            this.Controls.Add(this.college2NameTxt);
            this.Controls.Add(this.college1NameTxt);
            this.Controls.Add(this.collegeRoomLbl);
            this.Controls.Add(this.collegeTuitionLbl);
            this.Controls.Add(this.collegeApplicationLbl);
            this.Controls.Add(this.collegeDistanceLbl);
            this.Controls.Add(this.collegeTripsLbl);
            this.Controls.Add(this.college2Lbl);
            this.Controls.Add(this.college1Lbl);
            this.Controls.Add(this.collegeStateLbl);
            this.Controls.Add(this.collegeNameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label collegeNameLbl;
        private System.Windows.Forms.Label collegeStateLbl;
        private System.Windows.Forms.Label college1Lbl;
        private System.Windows.Forms.Label college2Lbl;
        private System.Windows.Forms.Label collegeTripsLbl;
        private System.Windows.Forms.Label collegeDistanceLbl;
        private System.Windows.Forms.Label collegeApplicationLbl;
        private System.Windows.Forms.Label collegeTuitionLbl;
        private System.Windows.Forms.Label collegeRoomLbl;
        private System.Windows.Forms.TextBox college1NameTxt;
        private System.Windows.Forms.TextBox college2NameTxt;
        private System.Windows.Forms.TextBox college1StateTxt;
        private System.Windows.Forms.TextBox college2StateTxt;
        private System.Windows.Forms.TextBox college1OneWayTxt;
        private System.Windows.Forms.TextBox college2OneWayTxt;
        private System.Windows.Forms.TextBox college1DistanceTxt;
        private System.Windows.Forms.TextBox college2DistanceTxt;
        private System.Windows.Forms.TextBox college1AppFeeTxt;
        private System.Windows.Forms.TextBox college2AppFeeTxt;
        private System.Windows.Forms.TextBox college1TuitionTxt;
        private System.Windows.Forms.TextBox college2TuitionTxt;
        private System.Windows.Forms.TextBox college1RoomTxt;
        private System.Windows.Forms.TextBox college2RoomTxt;
        private System.Windows.Forms.Label CalculationsLbl;
        private System.Windows.Forms.Label yearFuelCostLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label college1FuelCostLbl;
        private System.Windows.Forms.Label college2FuelCostLbl;
        private System.Windows.Forms.Label college1TotalCostLbl;
        private System.Windows.Forms.Label college2TotalCostLbl;
        private System.Windows.Forms.Button calculateBtn;
    }
}

