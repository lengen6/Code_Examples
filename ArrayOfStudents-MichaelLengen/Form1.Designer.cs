
namespace ArrayOfStudents_MichaelLengen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.addToArrayBtn = new System.Windows.Forms.Button();
            this.displayLbl = new System.Windows.Forms.Label();
            this.displayArrayBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instructionsLbl.Location = new System.Drawing.Point(215, 9);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(365, 144);
            this.instructionsLbl.TabIndex = 0;
            this.instructionsLbl.Text = resources.GetString("instructionsLbl.Text");
            this.instructionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLbl.Location = new System.Drawing.Point(109, 153);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(100, 38);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Student Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(109, 194);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 2;
            // 
            // gradeLbl
            // 
            this.gradeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradeLbl.Location = new System.Drawing.Point(586, 153);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(122, 38);
            this.gradeLbl.TabIndex = 3;
            this.gradeLbl.Text = "Course Grade as a Whole Number";
            this.gradeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradeTxt
            // 
            this.gradeTxt.Location = new System.Drawing.Point(586, 194);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.Size = new System.Drawing.Size(122, 20);
            this.gradeTxt.TabIndex = 4;
            // 
            // addToArrayBtn
            // 
            this.addToArrayBtn.Location = new System.Drawing.Point(307, 166);
            this.addToArrayBtn.Name = "addToArrayBtn";
            this.addToArrayBtn.Size = new System.Drawing.Size(182, 48);
            this.addToArrayBtn.TabIndex = 5;
            this.addToArrayBtn.Text = "Add Student to Grading Array";
            this.addToArrayBtn.UseVisualStyleBackColor = true;
            this.addToArrayBtn.Click += new System.EventHandler(this.addToArrayBtn_Click);
            // 
            // displayLbl
            // 
            this.displayLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayLbl.Location = new System.Drawing.Point(215, 243);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(365, 175);
            this.displayLbl.TabIndex = 6;
            // 
            // displayArrayBtn
            // 
            this.displayArrayBtn.Location = new System.Drawing.Point(12, 297);
            this.displayArrayBtn.Name = "displayArrayBtn";
            this.displayArrayBtn.Size = new System.Drawing.Size(182, 48);
            this.displayArrayBtn.TabIndex = 7;
            this.displayArrayBtn.Text = "Display Array: Students\' Names, Grades, And Average\r\n";
            this.displayArrayBtn.UseVisualStyleBackColor = true;
            this.displayArrayBtn.Click += new System.EventHandler(this.displayArrayBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(586, 297);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(182, 48);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear Display and Array";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.displayArrayBtn);
            this.Controls.Add(this.displayLbl);
            this.Controls.Add(this.addToArrayBtn);
            this.Controls.Add(this.gradeTxt);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.instructionsLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.TextBox gradeTxt;
        private System.Windows.Forms.Button addToArrayBtn;
        private System.Windows.Forms.Label displayLbl;
        private System.Windows.Forms.Button displayArrayBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

