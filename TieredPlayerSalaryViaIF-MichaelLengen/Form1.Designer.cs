
namespace TieredPlayerSalaryViaIF_MichaelLengen
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
            this.playerNameLbl = new System.Windows.Forms.Label();
            this.hitsLbl = new System.Windows.Forms.Label();
            this.playerNameTxt = new System.Windows.Forms.TextBox();
            this.numberOfHitsTxt = new System.Windows.Forms.TextBox();
            this.mvpCheck = new System.Windows.Forms.CheckBox();
            this.allStarCheck = new System.Windows.Forms.CheckBox();
            this.baseSalaryLbl = new System.Windows.Forms.Label();
            this.tierLbl = new System.Windows.Forms.Label();
            this.bonusPayLbl = new System.Windows.Forms.Label();
            this.totalSalaryLbl = new System.Windows.Forms.Label();
            this.tierResultLbl = new System.Windows.Forms.Label();
            this.baseSalaryResultLbl = new System.Windows.Forms.Label();
            this.mvpBonusResultLbl = new System.Windows.Forms.Label();
            this.totalSalaryResultLbl = new System.Windows.Forms.Label();
            this.leaderNameLbl = new System.Windows.Forms.Label();
            this.leadingPlayerTierLbl = new System.Windows.Forms.Label();
            this.leadingPlayerTotalSalaryLbl = new System.Windows.Forms.Label();
            this.LeadingNumberOfHitsLbl = new System.Windows.Forms.Label();
            this.leadingNameResultLbl = new System.Windows.Forms.Label();
            this.leadingTierResultLbl = new System.Windows.Forms.Label();
            this.leadingHitsResultsLbl = new System.Windows.Forms.Label();
            this.leadingSalaryResutlLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameLbl
            // 
            this.playerNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerNameLbl.Location = new System.Drawing.Point(12, 27);
            this.playerNameLbl.Name = "playerNameLbl";
            this.playerNameLbl.Size = new System.Drawing.Size(100, 23);
            this.playerNameLbl.TabIndex = 0;
            this.playerNameLbl.Text = "Enter Player Name: ";
            // 
            // hitsLbl
            // 
            this.hitsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hitsLbl.Location = new System.Drawing.Point(12, 68);
            this.hitsLbl.Name = "hitsLbl";
            this.hitsLbl.Size = new System.Drawing.Size(112, 23);
            this.hitsLbl.TabIndex = 1;
            this.hitsLbl.Text = "Enter Number of Hits: ";
            // 
            // playerNameTxt
            // 
            this.playerNameTxt.Location = new System.Drawing.Point(155, 30);
            this.playerNameTxt.Name = "playerNameTxt";
            this.playerNameTxt.Size = new System.Drawing.Size(100, 20);
            this.playerNameTxt.TabIndex = 2;
            // 
            // numberOfHitsTxt
            // 
            this.numberOfHitsTxt.Location = new System.Drawing.Point(155, 68);
            this.numberOfHitsTxt.Name = "numberOfHitsTxt";
            this.numberOfHitsTxt.Size = new System.Drawing.Size(100, 20);
            this.numberOfHitsTxt.TabIndex = 3;
            // 
            // mvpCheck
            // 
            this.mvpCheck.AutoSize = true;
            this.mvpCheck.Location = new System.Drawing.Point(12, 109);
            this.mvpCheck.Name = "mvpCheck";
            this.mvpCheck.Size = new System.Drawing.Size(49, 17);
            this.mvpCheck.TabIndex = 4;
            this.mvpCheck.Text = "MVP";
            this.mvpCheck.UseVisualStyleBackColor = true;
            // 
            // allStarCheck
            // 
            this.allStarCheck.AutoSize = true;
            this.allStarCheck.Location = new System.Drawing.Point(155, 109);
            this.allStarCheck.Name = "allStarCheck";
            this.allStarCheck.Size = new System.Drawing.Size(59, 17);
            this.allStarCheck.TabIndex = 5;
            this.allStarCheck.Text = "All Star";
            this.allStarCheck.UseVisualStyleBackColor = true;
            // 
            // baseSalaryLbl
            // 
            this.baseSalaryLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baseSalaryLbl.Location = new System.Drawing.Point(12, 214);
            this.baseSalaryLbl.Name = "baseSalaryLbl";
            this.baseSalaryLbl.Size = new System.Drawing.Size(100, 23);
            this.baseSalaryLbl.TabIndex = 6;
            this.baseSalaryLbl.Text = "Base Salary:";
            this.baseSalaryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tierLbl
            // 
            this.tierLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tierLbl.Location = new System.Drawing.Point(12, 180);
            this.tierLbl.Name = "tierLbl";
            this.tierLbl.Size = new System.Drawing.Size(100, 23);
            this.tierLbl.TabIndex = 7;
            this.tierLbl.Text = "Tier:";
            this.tierLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bonusPayLbl
            // 
            this.bonusPayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bonusPayLbl.Location = new System.Drawing.Point(12, 253);
            this.bonusPayLbl.Name = "bonusPayLbl";
            this.bonusPayLbl.Size = new System.Drawing.Size(100, 62);
            this.bonusPayLbl.TabIndex = 8;
            this.bonusPayLbl.Text = "Bonus Pay";
            this.bonusPayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalaryLbl
            // 
            this.totalSalaryLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalaryLbl.Location = new System.Drawing.Point(12, 324);
            this.totalSalaryLbl.Name = "totalSalaryLbl";
            this.totalSalaryLbl.Size = new System.Drawing.Size(100, 23);
            this.totalSalaryLbl.TabIndex = 10;
            this.totalSalaryLbl.Text = "Total Salary: ";
            this.totalSalaryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tierResultLbl
            // 
            this.tierResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tierResultLbl.Location = new System.Drawing.Point(155, 180);
            this.tierResultLbl.Name = "tierResultLbl";
            this.tierResultLbl.Size = new System.Drawing.Size(100, 23);
            this.tierResultLbl.TabIndex = 11;
            this.tierResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseSalaryResultLbl
            // 
            this.baseSalaryResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.baseSalaryResultLbl.Location = new System.Drawing.Point(155, 214);
            this.baseSalaryResultLbl.Name = "baseSalaryResultLbl";
            this.baseSalaryResultLbl.Size = new System.Drawing.Size(100, 23);
            this.baseSalaryResultLbl.TabIndex = 12;
            this.baseSalaryResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvpBonusResultLbl
            // 
            this.mvpBonusResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mvpBonusResultLbl.Location = new System.Drawing.Point(155, 253);
            this.mvpBonusResultLbl.Name = "mvpBonusResultLbl";
            this.mvpBonusResultLbl.Size = new System.Drawing.Size(100, 23);
            this.mvpBonusResultLbl.TabIndex = 13;
            this.mvpBonusResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalaryResultLbl
            // 
            this.totalSalaryResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalSalaryResultLbl.Location = new System.Drawing.Point(155, 324);
            this.totalSalaryResultLbl.Name = "totalSalaryResultLbl";
            this.totalSalaryResultLbl.Size = new System.Drawing.Size(100, 23);
            this.totalSalaryResultLbl.TabIndex = 15;
            this.totalSalaryResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leaderNameLbl
            // 
            this.leaderNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leaderNameLbl.Location = new System.Drawing.Point(372, 32);
            this.leaderNameLbl.Name = "leaderNameLbl";
            this.leaderNameLbl.Size = new System.Drawing.Size(161, 23);
            this.leaderNameLbl.TabIndex = 16;
            this.leaderNameLbl.Text = "Leading Player Name\r\n";
            this.leaderNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leadingPlayerTierLbl
            // 
            this.leadingPlayerTierLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadingPlayerTierLbl.Location = new System.Drawing.Point(372, 68);
            this.leadingPlayerTierLbl.Name = "leadingPlayerTierLbl";
            this.leadingPlayerTierLbl.Size = new System.Drawing.Size(161, 23);
            this.leadingPlayerTierLbl.TabIndex = 17;
            this.leadingPlayerTierLbl.Text = "Leading Player Tier: ";
            this.leadingPlayerTierLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leadingPlayerTotalSalaryLbl
            // 
            this.leadingPlayerTotalSalaryLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadingPlayerTotalSalaryLbl.Location = new System.Drawing.Point(372, 150);
            this.leadingPlayerTotalSalaryLbl.Name = "leadingPlayerTotalSalaryLbl";
            this.leadingPlayerTotalSalaryLbl.Size = new System.Drawing.Size(161, 23);
            this.leadingPlayerTotalSalaryLbl.TabIndex = 18;
            this.leadingPlayerTotalSalaryLbl.Text = "Leading Player Total Salary: ";
            this.leadingPlayerTotalSalaryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeadingNumberOfHitsLbl
            // 
            this.LeadingNumberOfHitsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeadingNumberOfHitsLbl.Location = new System.Drawing.Point(372, 109);
            this.LeadingNumberOfHitsLbl.Name = "LeadingNumberOfHitsLbl";
            this.LeadingNumberOfHitsLbl.Size = new System.Drawing.Size(161, 23);
            this.LeadingNumberOfHitsLbl.TabIndex = 19;
            this.LeadingNumberOfHitsLbl.Text = "Leading Player Number of Hits: ";
            this.LeadingNumberOfHitsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leadingNameResultLbl
            // 
            this.leadingNameResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadingNameResultLbl.Location = new System.Drawing.Point(574, 32);
            this.leadingNameResultLbl.Name = "leadingNameResultLbl";
            this.leadingNameResultLbl.Size = new System.Drawing.Size(100, 23);
            this.leadingNameResultLbl.TabIndex = 20;
            this.leadingNameResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leadingTierResultLbl
            // 
            this.leadingTierResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadingTierResultLbl.Location = new System.Drawing.Point(574, 79);
            this.leadingTierResultLbl.Name = "leadingTierResultLbl";
            this.leadingTierResultLbl.Size = new System.Drawing.Size(100, 23);
            this.leadingTierResultLbl.TabIndex = 21;
            this.leadingTierResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leadingHitsResultsLbl
            // 
            this.leadingHitsResultsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadingHitsResultsLbl.Location = new System.Drawing.Point(574, 109);
            this.leadingHitsResultsLbl.Name = "leadingHitsResultsLbl";
            this.leadingHitsResultsLbl.Size = new System.Drawing.Size(100, 23);
            this.leadingHitsResultsLbl.TabIndex = 22;
            this.leadingHitsResultsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leadingSalaryResutlLbl
            // 
            this.leadingSalaryResutlLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadingSalaryResutlLbl.Location = new System.Drawing.Point(574, 150);
            this.leadingSalaryResutlLbl.Name = "leadingSalaryResutlLbl";
            this.leadingSalaryResutlLbl.Size = new System.Drawing.Size(100, 23);
            this.leadingSalaryResutlLbl.TabIndex = 23;
            this.leadingSalaryResutlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(372, 214);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(302, 73);
            this.calculateBtn.TabIndex = 24;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(372, 299);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(302, 73);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.leadingSalaryResutlLbl);
            this.Controls.Add(this.leadingHitsResultsLbl);
            this.Controls.Add(this.leadingTierResultLbl);
            this.Controls.Add(this.leadingNameResultLbl);
            this.Controls.Add(this.LeadingNumberOfHitsLbl);
            this.Controls.Add(this.leadingPlayerTotalSalaryLbl);
            this.Controls.Add(this.leadingPlayerTierLbl);
            this.Controls.Add(this.leaderNameLbl);
            this.Controls.Add(this.totalSalaryResultLbl);
            this.Controls.Add(this.mvpBonusResultLbl);
            this.Controls.Add(this.baseSalaryResultLbl);
            this.Controls.Add(this.tierResultLbl);
            this.Controls.Add(this.totalSalaryLbl);
            this.Controls.Add(this.bonusPayLbl);
            this.Controls.Add(this.tierLbl);
            this.Controls.Add(this.baseSalaryLbl);
            this.Controls.Add(this.allStarCheck);
            this.Controls.Add(this.mvpCheck);
            this.Controls.Add(this.numberOfHitsTxt);
            this.Controls.Add(this.playerNameTxt);
            this.Controls.Add(this.hitsLbl);
            this.Controls.Add(this.playerNameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLbl;
        private System.Windows.Forms.Label hitsLbl;
        private System.Windows.Forms.TextBox playerNameTxt;
        private System.Windows.Forms.TextBox numberOfHitsTxt;
        private System.Windows.Forms.CheckBox mvpCheck;
        private System.Windows.Forms.CheckBox allStarCheck;
        private System.Windows.Forms.Label baseSalaryLbl;
        private System.Windows.Forms.Label tierLbl;
        private System.Windows.Forms.Label bonusPayLbl;
        private System.Windows.Forms.Label totalSalaryLbl;
        private System.Windows.Forms.Label tierResultLbl;
        private System.Windows.Forms.Label baseSalaryResultLbl;
        private System.Windows.Forms.Label mvpBonusResultLbl;
        private System.Windows.Forms.Label totalSalaryResultLbl;
        private System.Windows.Forms.Label leaderNameLbl;
        private System.Windows.Forms.Label leadingPlayerTierLbl;
        private System.Windows.Forms.Label leadingPlayerTotalSalaryLbl;
        private System.Windows.Forms.Label LeadingNumberOfHitsLbl;
        private System.Windows.Forms.Label leadingNameResultLbl;
        private System.Windows.Forms.Label leadingTierResultLbl;
        private System.Windows.Forms.Label leadingHitsResultsLbl;
        private System.Windows.Forms.Label leadingSalaryResutlLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

