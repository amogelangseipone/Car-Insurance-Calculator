using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCalculator
{
        public class UserData
        {
            public int Age { get; set; }
            public string Gender { get; set; }
            public int AccidentHistory { get; set; }

            public UserData(int age, string gender, int accidentHistory)
            {
                Age = age;
                Gender = gender;
                AccidentHistory = accidentHistory;
            }
        }

        public class InsuranceCalculator
        {
            public static int CalculateRiskScore(UserData user)
            {
                int riskScore = 0;

                // Age-based risk score
                if (user.Age < 25)
                    riskScore += 80;
                else if (user.Age >= 25 && user.Age <= 60)
                    riskScore += 50;
                else
                    riskScore += 70;

                // Gender-based risk score
                riskScore += user.Gender == "Female" ? 20 : 10;

                // Accident history-based risk score
                riskScore += user.AccidentHistory * 15;

                return riskScore;
            }

            public static decimal CalculatePremium(int riskScore)
            {
                return (riskScore * 5) + 100;
            }
        }
    
}
