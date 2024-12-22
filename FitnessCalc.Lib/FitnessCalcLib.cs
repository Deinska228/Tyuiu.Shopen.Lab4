using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCalc.Lib
{
    public class FitnessCalcLib
    {
        public double CalculateBMI(double weightKg, double heightM)
        {
            if (heightM <= 0)
            {
                heightM = 1;
            }
            return weightKg / (heightM * heightM);
        }

        public (double Calories, double Proteins, double Fats, double Carbohydrates) CalculateBMR(double weightKg, double heightCm, int age, string gender, string activityLevel)
        {
            double bmr = 0;
            if (gender.ToLower() == "male")
            {
                bmr = 88.362 + (13.397 * weightKg) + (4.799 * heightCm) - (5.677 * age);
            }
            else if (gender.ToLower() == "female")
            {
                bmr = 447.593 + (9.247 * weightKg) + (3.098 * heightCm) - (4.330 * age);
            }


            double activityMultiplier = 1.2;
            switch (activityLevel.ToLower())
            {
                case "Минимальная активность":
                    activityMultiplier = 1.375;
                    break;
                case "Умеренная активность":
                    activityMultiplier = 1.55;
                    break;
                case "Активный образ жизни":
                    activityMultiplier = 1.725;
                    break;
                case "Очень активный образ жизни":
                    activityMultiplier = 1.9;
                    break;
            }

            double calories = bmr * activityMultiplier;
            double proteins = calories * 0.3 / 4;
            double fats = calories * 0.25 / 9;
            double carbohydrates = calories * 0.45 / 4;

            return (calories, proteins, fats, carbohydrates);
        }
    }
}
