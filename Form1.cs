using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Input validation
            if (int.TryParse(txtAge.Text, out int age) && int.TryParse(txtAccidents.Text, out int accidents) && (cmbGender.SelectedItem != null))
            {
                string gender = cmbGender.SelectedItem.ToString();

                // Create a UserData object with the inputs
                UserData user = new UserData(age, gender, accidents);

                // Calculate risk score and premium
                int riskScore = InsuranceCalculator.CalculateRiskScore(user);
                decimal premium = InsuranceCalculator.CalculatePremium(riskScore);

                // Display results
                lblRiskScore.Text = $"Risk Score: {riskScore}";
                lblPremium.Text = $"Premium: R{premium.ToString("N2")}";
            }
            else
            {
                MessageBox.Show("Please enter valid inputs.");
            }
        }
    }
}
