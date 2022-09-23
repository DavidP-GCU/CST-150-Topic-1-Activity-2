namespace Activity_2__2nd__Attempt
{
    partial class activity2Conversion
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
            this.weightPounds = new System.Windows.Forms.Label();
            this.weightOunces = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.userInputLbs = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalOunces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightPounds
            // 
            this.weightPounds.AutoSize = true;
            this.weightPounds.Location = new System.Drawing.Point(27, 35);
            this.weightPounds.Name = "weightPounds";
            this.weightPounds.Size = new System.Drawing.Size(87, 13);
            this.weightPounds.TabIndex = 0;
            this.weightPounds.Text = "Total in Pounds: ";
            // 
            // weightOunces
            // 
            this.weightOunces.AutoSize = true;
            this.weightOunces.Location = new System.Drawing.Point(29, 90);
            this.weightOunces.Name = "weightOunces";
            this.weightOunces.Size = new System.Drawing.Size(85, 13);
            this.weightOunces.TabIndex = 1;
            this.weightOunces.Text = "Total in Ounces:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(114, 144);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(81, 47);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // userInputLbs
            // 
            this.userInputLbs.Location = new System.Drawing.Point(130, 35);
            this.userInputLbs.Name = "userInputLbs";
            this.userInputLbs.Size = new System.Drawing.Size(100, 20);
            this.userInputLbs.TabIndex = 3;
            this.userInputLbs.TextChanged += new System.EventHandler(this.userInputLbs_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 144);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(81, 47);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalOunces
            // 
            this.totalOunces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOunces.Location = new System.Drawing.Point(130, 85);
            this.totalOunces.Name = "totalOunces";
            this.totalOunces.Size = new System.Drawing.Size(100, 23);
            this.totalOunces.TabIndex = 5;
            this.totalOunces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activity2Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 271);
            this.Controls.Add(this.totalOunces);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.userInputLbs);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.weightOunces);
            this.Controls.Add(this.weightPounds);
            this.Name = "activity2Conversion";
            this.Text = "Your Weight in Ounces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightPounds;
        private System.Windows.Forms.Label weightOunces;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox userInputLbs;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalOunces;
    }
}

