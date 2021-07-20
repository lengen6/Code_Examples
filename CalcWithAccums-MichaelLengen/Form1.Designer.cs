
namespace CalcWithAccums_MichaelLengen
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
            this.companyNameLbl = new System.Windows.Forms.Label();
            this.mulchCalculatorLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.widthLbl = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.depthLbl = new System.Windows.Forms.Label();
            this.depthTxt = new System.Windows.Forms.TextBox();
            this.currentOrderLbl = new System.Windows.Forms.Label();
            this.cubicFtLbl = new System.Windows.Forms.Label();
            this.cubicYardsLbl = new System.Windows.Forms.Label();
            this.cubicFtResult = new System.Windows.Forms.Label();
            this.cubicYardsResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cubicFtAllLbl = new System.Windows.Forms.Label();
            this.cubicFtAllResult = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.costResult = new System.Windows.Forms.Label();
            this.cubicYardsAll = new System.Windows.Forms.Label();
            this.cubicYardsAllResult = new System.Windows.Forms.Label();
            this.costTotal = new System.Windows.Forms.Label();
            this.costTotalResult = new System.Windows.Forms.Label();
            this.numberOrders = new System.Windows.Forms.Label();
            this.numberOrdersResult = new System.Windows.Forms.Label();
            this.truckMathLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.emptyTruckLbl = new System.Windows.Forms.Label();
            this.truckCapacityInfo = new System.Windows.Forms.Label();
            this.lessTruckLbl = new System.Windows.Forms.Label();
            this.lessResult = new System.Windows.Forms.Label();
            this.remaingCapacity = new System.Windows.Forms.Label();
            this.remainingCapacityResult = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyNameLbl
            // 
            this.companyNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyNameLbl.Location = new System.Drawing.Point(12, 9);
            this.companyNameLbl.Name = "companyNameLbl";
            this.companyNameLbl.Size = new System.Drawing.Size(792, 23);
            this.companyNameLbl.TabIndex = 0;
            this.companyNameLbl.Text = "Michael Lengen\'s Landscaping Company";
            this.companyNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulchCalculatorLbl
            // 
            this.mulchCalculatorLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mulchCalculatorLbl.Location = new System.Drawing.Point(261, 45);
            this.mulchCalculatorLbl.Name = "mulchCalculatorLbl";
            this.mulchCalculatorLbl.Size = new System.Drawing.Size(272, 23);
            this.mulchCalculatorLbl.TabIndex = 1;
            this.mulchCalculatorLbl.Text = "Mulch Calculator";
            this.mulchCalculatorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthLbl
            // 
            this.lengthLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lengthLbl.Location = new System.Drawing.Point(261, 83);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(99, 23);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "Length (ft)";
            this.lengthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(431, 85);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(102, 20);
            this.lengthTxt.TabIndex = 3;
            // 
            // widthLbl
            // 
            this.widthLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.widthLbl.Location = new System.Drawing.Point(261, 106);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(99, 23);
            this.widthLbl.TabIndex = 4;
            this.widthLbl.Text = "Width (ft)";
            this.widthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(431, 109);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(102, 20);
            this.widthTxt.TabIndex = 5;
            // 
            // depthLbl
            // 
            this.depthLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.depthLbl.Location = new System.Drawing.Point(261, 129);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(99, 23);
            this.depthLbl.TabIndex = 6;
            this.depthLbl.Text = "Depth (ft)";
            this.depthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthTxt
            // 
            this.depthTxt.Location = new System.Drawing.Point(431, 135);
            this.depthTxt.Name = "depthTxt";
            this.depthTxt.Size = new System.Drawing.Size(102, 20);
            this.depthTxt.TabIndex = 7;
            // 
            // currentOrderLbl
            // 
            this.currentOrderLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentOrderLbl.Location = new System.Drawing.Point(12, 166);
            this.currentOrderLbl.Name = "currentOrderLbl";
            this.currentOrderLbl.Size = new System.Drawing.Size(249, 23);
            this.currentOrderLbl.TabIndex = 8;
            this.currentOrderLbl.Text = "Current Order";
            this.currentOrderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicFtLbl
            // 
            this.cubicFtLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicFtLbl.Location = new System.Drawing.Point(12, 205);
            this.cubicFtLbl.Name = "cubicFtLbl";
            this.cubicFtLbl.Size = new System.Drawing.Size(99, 23);
            this.cubicFtLbl.TabIndex = 9;
            this.cubicFtLbl.Text = "Cubic Feet";
            this.cubicFtLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicYardsLbl
            // 
            this.cubicYardsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicYardsLbl.Location = new System.Drawing.Point(12, 243);
            this.cubicYardsLbl.Name = "cubicYardsLbl";
            this.cubicYardsLbl.Size = new System.Drawing.Size(99, 23);
            this.cubicYardsLbl.TabIndex = 11;
            this.cubicYardsLbl.Text = "Cubic Yards";
            this.cubicYardsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicFtResult
            // 
            this.cubicFtResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicFtResult.Location = new System.Drawing.Point(162, 205);
            this.cubicFtResult.Name = "cubicFtResult";
            this.cubicFtResult.Size = new System.Drawing.Size(99, 23);
            this.cubicFtResult.TabIndex = 12;
            this.cubicFtResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicYardsResult
            // 
            this.cubicYardsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicYardsResult.Location = new System.Drawing.Point(162, 243);
            this.cubicYardsResult.Name = "cubicYardsResult";
            this.cubicYardsResult.Size = new System.Drawing.Size(99, 23);
            this.cubicYardsResult.TabIndex = 13;
            this.cubicYardsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(539, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Current Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicFtAllLbl
            // 
            this.cubicFtAllLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicFtAllLbl.Location = new System.Drawing.Point(539, 205);
            this.cubicFtAllLbl.Name = "cubicFtAllLbl";
            this.cubicFtAllLbl.Size = new System.Drawing.Size(123, 23);
            this.cubicFtAllLbl.TabIndex = 15;
            this.cubicFtAllLbl.Text = "Cubic Feet (all orders)";
            this.cubicFtAllLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicFtAllResult
            // 
            this.cubicFtAllResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicFtAllResult.Location = new System.Drawing.Point(689, 205);
            this.cubicFtAllResult.Name = "cubicFtAllResult";
            this.cubicFtAllResult.Size = new System.Drawing.Size(99, 23);
            this.cubicFtAllResult.TabIndex = 16;
            this.cubicFtAllResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLbl
            // 
            this.costLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLbl.Location = new System.Drawing.Point(12, 280);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(99, 23);
            this.costLbl.TabIndex = 17;
            this.costLbl.Text = "Cost @";
            this.costLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costResult
            // 
            this.costResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costResult.Location = new System.Drawing.Point(162, 280);
            this.costResult.Name = "costResult";
            this.costResult.Size = new System.Drawing.Size(99, 23);
            this.costResult.TabIndex = 18;
            this.costResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicYardsAll
            // 
            this.cubicYardsAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicYardsAll.Location = new System.Drawing.Point(539, 243);
            this.cubicYardsAll.Name = "cubicYardsAll";
            this.cubicYardsAll.Size = new System.Drawing.Size(123, 23);
            this.cubicYardsAll.TabIndex = 19;
            this.cubicYardsAll.Text = "Cubic Yards (all orders)";
            this.cubicYardsAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicYardsAllResult
            // 
            this.cubicYardsAllResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cubicYardsAllResult.Location = new System.Drawing.Point(689, 243);
            this.cubicYardsAllResult.Name = "cubicYardsAllResult";
            this.cubicYardsAllResult.Size = new System.Drawing.Size(99, 23);
            this.cubicYardsAllResult.TabIndex = 20;
            this.cubicYardsAllResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTotal
            // 
            this.costTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costTotal.Location = new System.Drawing.Point(539, 280);
            this.costTotal.Name = "costTotal";
            this.costTotal.Size = new System.Drawing.Size(123, 23);
            this.costTotal.TabIndex = 21;
            this.costTotal.Text = "Cost (all orders)";
            this.costTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costTotalResult
            // 
            this.costTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costTotalResult.Location = new System.Drawing.Point(689, 280);
            this.costTotalResult.Name = "costTotalResult";
            this.costTotalResult.Size = new System.Drawing.Size(99, 23);
            this.costTotalResult.TabIndex = 22;
            this.costTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOrders
            // 
            this.numberOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberOrders.Location = new System.Drawing.Point(539, 313);
            this.numberOrders.Name = "numberOrders";
            this.numberOrders.Size = new System.Drawing.Size(123, 23);
            this.numberOrders.TabIndex = 23;
            this.numberOrders.Text = "Number of Orders";
            this.numberOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOrdersResult
            // 
            this.numberOrdersResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberOrdersResult.Location = new System.Drawing.Point(689, 313);
            this.numberOrdersResult.Name = "numberOrdersResult";
            this.numberOrdersResult.Size = new System.Drawing.Size(99, 23);
            this.numberOrdersResult.TabIndex = 24;
            this.numberOrdersResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truckMathLbl
            // 
            this.truckMathLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.truckMathLbl.Location = new System.Drawing.Point(12, 348);
            this.truckMathLbl.Name = "truckMathLbl";
            this.truckMathLbl.Size = new System.Drawing.Size(776, 23);
            this.truckMathLbl.TabIndex = 25;
            this.truckMathLbl.Text = "Truck Information\r\n";
            this.truckMathLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(305, 185);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(193, 43);
            this.calculateBtn.TabIndex = 26;
            this.calculateBtn.Text = "Submit Order";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // emptyTruckLbl
            // 
            this.emptyTruckLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emptyTruckLbl.Location = new System.Drawing.Point(12, 389);
            this.emptyTruckLbl.Name = "emptyTruckLbl";
            this.emptyTruckLbl.Size = new System.Drawing.Size(116, 40);
            this.emptyTruckLbl.TabIndex = 27;
            this.emptyTruckLbl.Text = "Empty Truck Capacity (cubic yards)\r\n";
            this.emptyTruckLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truckCapacityInfo
            // 
            this.truckCapacityInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.truckCapacityInfo.Location = new System.Drawing.Point(162, 398);
            this.truckCapacityInfo.Name = "truckCapacityInfo";
            this.truckCapacityInfo.Size = new System.Drawing.Size(99, 23);
            this.truckCapacityInfo.TabIndex = 28;
            this.truckCapacityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lessTruckLbl
            // 
            this.lessTruckLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lessTruckLbl.Location = new System.Drawing.Point(305, 389);
            this.lessTruckLbl.Name = "lessTruckLbl";
            this.lessTruckLbl.Size = new System.Drawing.Size(116, 40);
            this.lessTruckLbl.TabIndex = 29;
            this.lessTruckLbl.Text = "Less: Ordered (cubic yards)";
            this.lessTruckLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lessResult
            // 
            this.lessResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lessResult.Location = new System.Drawing.Point(434, 398);
            this.lessResult.Name = "lessResult";
            this.lessResult.Size = new System.Drawing.Size(99, 23);
            this.lessResult.TabIndex = 30;
            this.lessResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remaingCapacity
            // 
            this.remaingCapacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remaingCapacity.Location = new System.Drawing.Point(546, 389);
            this.remaingCapacity.Name = "remaingCapacity";
            this.remaingCapacity.Size = new System.Drawing.Size(116, 40);
            this.remaingCapacity.TabIndex = 31;
            this.remaingCapacity.Text = "Equals: Remaining Truck Capacity";
            this.remaingCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingCapacityResult
            // 
            this.remainingCapacityResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remainingCapacityResult.Location = new System.Drawing.Point(689, 406);
            this.remainingCapacityResult.Name = "remainingCapacityResult";
            this.remainingCapacityResult.Size = new System.Drawing.Size(99, 23);
            this.remainingCapacityResult.TabIndex = 32;
            this.remainingCapacityResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(305, 260);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(193, 43);
            this.clearBtn.TabIndex = 33;
            this.clearBtn.Text = "Clear All Order Data";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.remainingCapacityResult);
            this.Controls.Add(this.remaingCapacity);
            this.Controls.Add(this.lessResult);
            this.Controls.Add(this.lessTruckLbl);
            this.Controls.Add(this.truckCapacityInfo);
            this.Controls.Add(this.emptyTruckLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.truckMathLbl);
            this.Controls.Add(this.numberOrdersResult);
            this.Controls.Add(this.numberOrders);
            this.Controls.Add(this.costTotalResult);
            this.Controls.Add(this.costTotal);
            this.Controls.Add(this.cubicYardsAllResult);
            this.Controls.Add(this.cubicYardsAll);
            this.Controls.Add(this.costResult);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.cubicFtAllResult);
            this.Controls.Add(this.cubicFtAllLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cubicYardsResult);
            this.Controls.Add(this.cubicFtResult);
            this.Controls.Add(this.cubicYardsLbl);
            this.Controls.Add(this.cubicFtLbl);
            this.Controls.Add(this.currentOrderLbl);
            this.Controls.Add(this.depthTxt);
            this.Controls.Add(this.depthLbl);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.mulchCalculatorLbl);
            this.Controls.Add(this.companyNameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLbl;
        private System.Windows.Forms.Label mulchCalculatorLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.Label depthLbl;
        private System.Windows.Forms.TextBox depthTxt;
        private System.Windows.Forms.Label currentOrderLbl;
        private System.Windows.Forms.Label cubicFtLbl;
        private System.Windows.Forms.Label cubicYardsLbl;
        private System.Windows.Forms.Label cubicFtResult;
        private System.Windows.Forms.Label cubicYardsResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cubicFtAllLbl;
        private System.Windows.Forms.Label cubicFtAllResult;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label costResult;
        private System.Windows.Forms.Label cubicYardsAll;
        private System.Windows.Forms.Label cubicYardsAllResult;
        private System.Windows.Forms.Label costTotal;
        private System.Windows.Forms.Label costTotalResult;
        private System.Windows.Forms.Label numberOrders;
        private System.Windows.Forms.Label numberOrdersResult;
        private System.Windows.Forms.Label truckMathLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label emptyTruckLbl;
        private System.Windows.Forms.Label truckCapacityInfo;
        private System.Windows.Forms.Label lessTruckLbl;
        private System.Windows.Forms.Label lessResult;
        private System.Windows.Forms.Label remaingCapacity;
        private System.Windows.Forms.Label remainingCapacityResult;
        private System.Windows.Forms.Button clearBtn;
    }
}

