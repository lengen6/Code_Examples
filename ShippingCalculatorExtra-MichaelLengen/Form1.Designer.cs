
namespace ShippingCalculator_MichaelLengen
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
            this.pkgWeightLbl = new System.Windows.Forms.Label();
            this.zoneLbl = new System.Windows.Forms.Label();
            this.pkgWeightTxt = new System.Windows.Forms.TextBox();
            this.pkgWeightCostLbl = new System.Windows.Forms.Label();
            this.pkgWeightCostResult = new System.Windows.Forms.Label();
            this.pkgZoneCostLbl = new System.Windows.Forms.Label();
            this.pkgZoneCostResult = new System.Windows.Forms.Label();
            this.pkgTotalCostLbl = new System.Windows.Forms.Label();
            this.pkgTotalCostResult = new System.Windows.Forms.Label();
            this.capLbl = new System.Windows.Forms.Label();
            this.capResult = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.costPerWeightLbl = new System.Windows.Forms.Label();
            this.costPerWeightResult = new System.Windows.Forms.Label();
            this.radioN = new System.Windows.Forms.RadioButton();
            this.radioS = new System.Windows.Forms.RadioButton();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.radioW = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // pkgWeightLbl
            // 
            this.pkgWeightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgWeightLbl.Location = new System.Drawing.Point(258, 24);
            this.pkgWeightLbl.Name = "pkgWeightLbl";
            this.pkgWeightLbl.Size = new System.Drawing.Size(132, 23);
            this.pkgWeightLbl.TabIndex = 0;
            this.pkgWeightLbl.Text = "Enter Package Weight";
            this.pkgWeightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoneLbl
            // 
            this.zoneLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zoneLbl.Location = new System.Drawing.Point(258, 72);
            this.zoneLbl.Name = "zoneLbl";
            this.zoneLbl.Size = new System.Drawing.Size(132, 31);
            this.zoneLbl.TabIndex = 1;
            this.zoneLbl.Text = "Enter Zone Shipped To\r\n(N,S,E,W)\r\n";
            this.zoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkgWeightTxt
            // 
            this.pkgWeightTxt.Location = new System.Drawing.Point(439, 26);
            this.pkgWeightTxt.Name = "pkgWeightTxt";
            this.pkgWeightTxt.Size = new System.Drawing.Size(100, 20);
            this.pkgWeightTxt.TabIndex = 2;
            // 
            // pkgWeightCostLbl
            // 
            this.pkgWeightCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgWeightCostLbl.Location = new System.Drawing.Point(12, 182);
            this.pkgWeightCostLbl.Name = "pkgWeightCostLbl";
            this.pkgWeightCostLbl.Size = new System.Drawing.Size(132, 31);
            this.pkgWeightCostLbl.TabIndex = 4;
            this.pkgWeightCostLbl.Text = "Package Weight Cost";
            this.pkgWeightCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkgWeightCostResult
            // 
            this.pkgWeightCostResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgWeightCostResult.Location = new System.Drawing.Point(12, 229);
            this.pkgWeightCostResult.Name = "pkgWeightCostResult";
            this.pkgWeightCostResult.Size = new System.Drawing.Size(132, 31);
            this.pkgWeightCostResult.TabIndex = 5;
            this.pkgWeightCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkgZoneCostLbl
            // 
            this.pkgZoneCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgZoneCostLbl.Location = new System.Drawing.Point(166, 182);
            this.pkgZoneCostLbl.Name = "pkgZoneCostLbl";
            this.pkgZoneCostLbl.Size = new System.Drawing.Size(132, 31);
            this.pkgZoneCostLbl.TabIndex = 6;
            this.pkgZoneCostLbl.Text = "Package Zone Cost";
            this.pkgZoneCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkgZoneCostResult
            // 
            this.pkgZoneCostResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgZoneCostResult.Location = new System.Drawing.Point(166, 229);
            this.pkgZoneCostResult.Name = "pkgZoneCostResult";
            this.pkgZoneCostResult.Size = new System.Drawing.Size(132, 31);
            this.pkgZoneCostResult.TabIndex = 7;
            this.pkgZoneCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkgTotalCostLbl
            // 
            this.pkgTotalCostLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgTotalCostLbl.Location = new System.Drawing.Point(322, 182);
            this.pkgTotalCostLbl.Name = "pkgTotalCostLbl";
            this.pkgTotalCostLbl.Size = new System.Drawing.Size(132, 31);
            this.pkgTotalCostLbl.TabIndex = 8;
            this.pkgTotalCostLbl.Text = "Package Total Cost";
            this.pkgTotalCostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkgTotalCostResult
            // 
            this.pkgTotalCostResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pkgTotalCostResult.Location = new System.Drawing.Point(322, 229);
            this.pkgTotalCostResult.Name = "pkgTotalCostResult";
            this.pkgTotalCostResult.Size = new System.Drawing.Size(132, 31);
            this.pkgTotalCostResult.TabIndex = 9;
            this.pkgTotalCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capLbl
            // 
            this.capLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capLbl.Location = new System.Drawing.Point(479, 182);
            this.capLbl.Name = "capLbl";
            this.capLbl.Size = new System.Drawing.Size(132, 31);
            this.capLbl.TabIndex = 10;
            this.capLbl.Text = "Cap Hit?";
            this.capLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capResult
            // 
            this.capResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capResult.Location = new System.Drawing.Point(479, 229);
            this.capResult.Name = "capResult";
            this.capResult.Size = new System.Drawing.Size(132, 31);
            this.capResult.TabIndex = 11;
            this.capResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(258, 310);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(313, 76);
            this.calculateBtn.TabIndex = 12;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // costPerWeightLbl
            // 
            this.costPerWeightLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costPerWeightLbl.Location = new System.Drawing.Point(656, 182);
            this.costPerWeightLbl.Name = "costPerWeightLbl";
            this.costPerWeightLbl.Size = new System.Drawing.Size(132, 31);
            this.costPerWeightLbl.TabIndex = 13;
            this.costPerWeightLbl.Text = "Cost Per Pound";
            this.costPerWeightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costPerWeightResult
            // 
            this.costPerWeightResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costPerWeightResult.Location = new System.Drawing.Point(656, 229);
            this.costPerWeightResult.Name = "costPerWeightResult";
            this.costPerWeightResult.Size = new System.Drawing.Size(132, 31);
            this.costPerWeightResult.TabIndex = 14;
            this.costPerWeightResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioN
            // 
            this.radioN.AutoSize = true;
            this.radioN.Location = new System.Drawing.Point(439, 52);
            this.radioN.Name = "radioN";
            this.radioN.Size = new System.Drawing.Size(33, 17);
            this.radioN.TabIndex = 15;
            this.radioN.TabStop = true;
            this.radioN.Text = "N";
            this.radioN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioN.UseVisualStyleBackColor = true;
            // 
            // radioS
            // 
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(439, 86);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(32, 17);
            this.radioS.TabIndex = 16;
            this.radioS.TabStop = true;
            this.radioS.Text = "S";
            this.radioS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioS.UseVisualStyleBackColor = true;
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.Location = new System.Drawing.Point(506, 52);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(32, 17);
            this.radioE.TabIndex = 17;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioE.UseVisualStyleBackColor = true;
            // 
            // radioW
            // 
            this.radioW.AutoSize = true;
            this.radioW.Location = new System.Drawing.Point(505, 86);
            this.radioW.Name = "radioW";
            this.radioW.Size = new System.Drawing.Size(36, 17);
            this.radioW.TabIndex = 18;
            this.radioW.TabStop = true;
            this.radioW.Text = "W";
            this.radioW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioW.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioW);
            this.Controls.Add(this.radioE);
            this.Controls.Add(this.radioS);
            this.Controls.Add(this.radioN);
            this.Controls.Add(this.costPerWeightResult);
            this.Controls.Add(this.costPerWeightLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.capResult);
            this.Controls.Add(this.capLbl);
            this.Controls.Add(this.pkgTotalCostResult);
            this.Controls.Add(this.pkgTotalCostLbl);
            this.Controls.Add(this.pkgZoneCostResult);
            this.Controls.Add(this.pkgZoneCostLbl);
            this.Controls.Add(this.pkgWeightCostResult);
            this.Controls.Add(this.pkgWeightCostLbl);
            this.Controls.Add(this.pkgWeightTxt);
            this.Controls.Add(this.zoneLbl);
            this.Controls.Add(this.pkgWeightLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pkgWeightLbl;
        private System.Windows.Forms.Label zoneLbl;
        private System.Windows.Forms.TextBox pkgWeightTxt;
        private System.Windows.Forms.Label pkgWeightCostLbl;
        private System.Windows.Forms.Label pkgWeightCostResult;
        private System.Windows.Forms.Label pkgZoneCostLbl;
        private System.Windows.Forms.Label pkgZoneCostResult;
        private System.Windows.Forms.Label pkgTotalCostLbl;
        private System.Windows.Forms.Label pkgTotalCostResult;
        private System.Windows.Forms.Label capLbl;
        private System.Windows.Forms.Label capResult;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label costPerWeightLbl;
        private System.Windows.Forms.Label costPerWeightResult;
        private System.Windows.Forms.RadioButton radioN;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.RadioButton radioW;
    }
}

