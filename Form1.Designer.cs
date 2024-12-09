
namespace InsuranceCalculator
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
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccidents = new System.Windows.Forms.TextBox();
            this.lblRiskScore = new System.Windows.Forms.Label();
            this.lblPremium = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 9);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(150, 9);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 57);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(129, 54);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 24);
            this.cmbGender.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Accident History";
            // 
            // txtAccidents
            // 
            this.txtAccidents.Location = new System.Drawing.Point(150, 108);
            this.txtAccidents.Name = "txtAccidents";
            this.txtAccidents.Size = new System.Drawing.Size(100, 22);
            this.txtAccidents.TabIndex = 13;
            // 
            // lblRiskScore
            // 
            this.lblRiskScore.AutoSize = true;
            this.lblRiskScore.Location = new System.Drawing.Point(12, 164);
            this.lblRiskScore.Name = "lblRiskScore";
            this.lblRiskScore.Size = new System.Drawing.Size(76, 17);
            this.lblRiskScore.TabIndex = 14;
            this.lblRiskScore.Text = "Risk Score";
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Location = new System.Drawing.Point(12, 203);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(63, 17);
            this.lblPremium.TabIndex = 15;
            this.lblPremium.Text = "Premium";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(150, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 31);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 274);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPremium);
            this.Controls.Add(this.lblRiskScore);
            this.Controls.Add(this.txtAccidents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccidents;
        private System.Windows.Forms.Label lblRiskScore;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Button btnCalculate;
    }
}

