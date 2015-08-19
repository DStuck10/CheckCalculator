namespace CheckCalculator
{
    partial class CheckCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckCalculator));
            this.enter = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.socialSecurityTextBox = new System.Windows.Forms.TextBox();
            this.medicareTaxTextBox = new System.Windows.Forms.TextBox();
            this.paIncomeTaxTextBox = new System.Windows.Forms.TextBox();
            this.decaturTownshipTaxTextBox = new System.Windows.Forms.TextBox();
            this.socialSecurityTaxLabel = new System.Windows.Forms.Label();
            this.medicareTaxLabel = new System.Windows.Forms.Label();
            this.paIncomeTaxLabel = new System.Windows.Forms.Label();
            this.decaturTownshipTaxLabel = new System.Windows.Forms.Label();
            this.paSUISDITaxTextBox = new System.Windows.Forms.TextBox();
            this.PaSUISDITax = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.netPayTextBox = new System.Windows.Forms.TextBox();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.hourlyPayTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(223, 207);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 3;
            this.enter.Text = "&Calculate";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click_1);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(385, 207);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 5;
            this.close.Text = "&Exit";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(13, 25);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(39, 20);
            this.hoursTextBox.TabIndex = 1;
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Location = new System.Drawing.Point(10, 9);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(228, 13);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Type the amount of hours in the text box below";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(304, 207);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "C&lear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // socialSecurityTextBox
            // 
            this.socialSecurityTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.socialSecurityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.socialSecurityTextBox.Enabled = false;
            this.socialSecurityTextBox.Location = new System.Drawing.Point(13, 125);
            this.socialSecurityTextBox.Name = "socialSecurityTextBox";
            this.socialSecurityTextBox.Size = new System.Drawing.Size(65, 13);
            this.socialSecurityTextBox.TabIndex = 0;
            this.socialSecurityTextBox.TabStop = false;
            this.socialSecurityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            // 
            // medicareTaxTextBox
            // 
            this.medicareTaxTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.medicareTaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicareTaxTextBox.Enabled = false;
            this.medicareTaxTextBox.Location = new System.Drawing.Point(13, 144);
            this.medicareTaxTextBox.Name = "medicareTaxTextBox";
            this.medicareTaxTextBox.Size = new System.Drawing.Size(65, 13);
            this.medicareTaxTextBox.TabIndex = 0;
            this.medicareTaxTextBox.TabStop = false;
            this.medicareTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            // 
            // paIncomeTaxTextBox
            // 
            this.paIncomeTaxTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paIncomeTaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paIncomeTaxTextBox.Enabled = false;
            this.paIncomeTaxTextBox.Location = new System.Drawing.Point(13, 163);
            this.paIncomeTaxTextBox.Name = "paIncomeTaxTextBox";
            this.paIncomeTaxTextBox.Size = new System.Drawing.Size(65, 13);
            this.paIncomeTaxTextBox.TabIndex = 0;
            this.paIncomeTaxTextBox.TabStop = false;
            this.paIncomeTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
           
            // 
            // decaturTownshipTaxTextBox
            // 
            this.decaturTownshipTaxTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.decaturTownshipTaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decaturTownshipTaxTextBox.Enabled = false;
            this.decaturTownshipTaxTextBox.Location = new System.Drawing.Point(13, 182);
            this.decaturTownshipTaxTextBox.Name = "decaturTownshipTaxTextBox";
            this.decaturTownshipTaxTextBox.Size = new System.Drawing.Size(65, 13);
            this.decaturTownshipTaxTextBox.TabIndex = 0;
            this.decaturTownshipTaxTextBox.TabStop = false;
            this.decaturTownshipTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            // 
            // socialSecurityTaxLabel
            // 
            this.socialSecurityTaxLabel.AutoSize = true;
            this.socialSecurityTaxLabel.Location = new System.Drawing.Point(78, 122);
            this.socialSecurityTaxLabel.Name = "socialSecurityTaxLabel";
            this.socialSecurityTaxLabel.Size = new System.Drawing.Size(113, 13);
            this.socialSecurityTaxLabel.TabIndex = 0;
            this.socialSecurityTaxLabel.Text = ".... Social Security Tax";
            // 
            // medicareTaxLabel
            // 
            this.medicareTaxLabel.AutoSize = true;
            this.medicareTaxLabel.Location = new System.Drawing.Point(78, 141);
            this.medicareTaxLabel.Name = "medicareTaxLabel";
            this.medicareTaxLabel.Size = new System.Drawing.Size(87, 13);
            this.medicareTaxLabel.TabIndex = 0;
            this.medicareTaxLabel.Text = ".... Medicare Tax";
            // 
            // paIncomeTaxLabel
            // 
            this.paIncomeTaxLabel.AutoSize = true;
            this.paIncomeTaxLabel.Location = new System.Drawing.Point(78, 160);
            this.paIncomeTaxLabel.Name = "paIncomeTaxLabel";
            this.paIncomeTaxLabel.Size = new System.Drawing.Size(95, 13);
            this.paIncomeTaxLabel.TabIndex = 0;
            this.paIncomeTaxLabel.Text = ".... PA Income Tax";
            // 
            // decaturTownshipTaxLabel
            // 
            this.decaturTownshipTaxLabel.AutoSize = true;
            this.decaturTownshipTaxLabel.Location = new System.Drawing.Point(78, 179);
            this.decaturTownshipTaxLabel.Name = "decaturTownshipTaxLabel";
            this.decaturTownshipTaxLabel.Size = new System.Drawing.Size(130, 13);
            this.decaturTownshipTaxLabel.TabIndex = 0;
            this.decaturTownshipTaxLabel.Text = ".... Decatur Township Tax";
            // 
            // paSUISDITaxTextBox
            // 
            this.paSUISDITaxTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paSUISDITaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paSUISDITaxTextBox.Enabled = false;
            this.paSUISDITaxTextBox.Location = new System.Drawing.Point(13, 200);
            this.paSUISDITaxTextBox.Name = "paSUISDITaxTextBox";
            this.paSUISDITaxTextBox.Size = new System.Drawing.Size(65, 13);
            this.paSUISDITaxTextBox.TabIndex = 0;
            this.paSUISDITaxTextBox.TabStop = false;
            this.paSUISDITaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
           
            // 
            // PaSUISDITax
            // 
            this.PaSUISDITax.AutoSize = true;
            this.PaSUISDITax.Location = new System.Drawing.Point(78, 198);
            this.PaSUISDITax.Name = "PaSUISDITax";
            this.PaSUISDITax.Size = new System.Drawing.Size(101, 13);
            this.PaSUISDITax.TabIndex = 0;
            this.PaSUISDITax.Text = ".... PA SUI/SDI Tax";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grossPayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grossPayTextBox.Enabled = false;
            this.grossPayTextBox.Location = new System.Drawing.Point(13, 106);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(65, 13);
            this.grossPayTextBox.TabIndex = 0;
            this.grossPayTextBox.TabStop = false;
            this.grossPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(78, 104);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(70, 13);
            this.grossPayLabel.TabIndex = 0;
            this.grossPayLabel.Text = ".... Gross Pay";
            // 
            // netPayTextBox
            // 
            this.netPayTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.netPayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.netPayTextBox.Enabled = false;
            this.netPayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayTextBox.Location = new System.Drawing.Point(241, 105);
            this.netPayTextBox.Name = "netPayTextBox";
            this.netPayTextBox.Size = new System.Drawing.Size(79, 13);
            this.netPayTextBox.TabIndex = 0;
            this.netPayTextBox.TabStop = false;
            this.netPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.Location = new System.Drawing.Point(321, 104);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(60, 13);
            this.netPayLabel.TabIndex = 0;
            this.netPayLabel.Text = ".... Net Pay";
            // 
            // hourlyPayTextBox
            // 
            this.hourlyPayTextBox.Location = new System.Drawing.Point(13, 66);
            this.hourlyPayTextBox.Name = "hourlyPayTextBox";
            this.hourlyPayTextBox.Size = new System.Drawing.Size(39, 20);
            this.hourlyPayTextBox.TabIndex = 2;
            // 
            // hourlyPayLabel
            // 
            this.hourlyPayLabel.AutoSize = true;
            this.hourlyPayLabel.Location = new System.Drawing.Point(11, 50);
            this.hourlyPayLabel.Name = "hourlyPayLabel";
            this.hourlyPayLabel.Size = new System.Drawing.Size(151, 13);
            this.hourlyPayLabel.TabIndex = 6;
            this.hourlyPayLabel.Text = "Type hourly pay in the text box";
            // 
            // CheckCalculator
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(472, 240);
            this.Controls.Add(this.hourlyPayLabel);
            this.Controls.Add(this.hourlyPayTextBox);
            this.Controls.Add(this.netPayLabel);
            this.Controls.Add(this.netPayTextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.PaSUISDITax);
            this.Controls.Add(this.paSUISDITaxTextBox);
            this.Controls.Add(this.decaturTownshipTaxLabel);
            this.Controls.Add(this.paIncomeTaxLabel);
            this.Controls.Add(this.medicareTaxLabel);
            this.Controls.Add(this.socialSecurityTaxLabel);
            this.Controls.Add(this.decaturTownshipTaxTextBox);
            this.Controls.Add(this.paIncomeTaxTextBox);
            this.Controls.Add(this.medicareTaxTextBox);
            this.Controls.Add(this.socialSecurityTextBox);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.close);
            this.Controls.Add(this.enter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckCalculator";
            this.Text = "Check Calculator";
            this.Load += new System.EventHandler(this.CheckCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox socialSecurityTextBox;
        private System.Windows.Forms.TextBox medicareTaxTextBox;
        private System.Windows.Forms.TextBox paIncomeTaxTextBox;
        private System.Windows.Forms.TextBox decaturTownshipTaxTextBox;
        private System.Windows.Forms.Label socialSecurityTaxLabel;
        private System.Windows.Forms.Label medicareTaxLabel;
        private System.Windows.Forms.Label paIncomeTaxLabel;
        private System.Windows.Forms.Label decaturTownshipTaxLabel;
        private System.Windows.Forms.TextBox paSUISDITaxTextBox;
        private System.Windows.Forms.Label PaSUISDITax;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.TextBox netPayTextBox;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.TextBox hourlyPayTextBox;
        private System.Windows.Forms.Label hourlyPayLabel;
    }
}

