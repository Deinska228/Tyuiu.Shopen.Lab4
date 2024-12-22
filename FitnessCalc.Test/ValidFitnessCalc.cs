using FitnessCalc.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FitnessCalc.Test
{
    [TestClass]
    public class ValidFitnessCalc
    {
        private FitnessCalcLib calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new FitnessCalcLib();
        }

        [TestMethod]
        public void TestCalculateBMI()
        {
            double result = calculator.CalculateBMI(70, 1.75);
            Assert.AreEqual(22.857, result, 0.001);
        }

        [TestMethod]
        public void TestCalculateBMIWithZeroHeight()
        {
            double result = calculator.CalculateBMI(70, 0);
            Assert.AreEqual(70, result, 0.001);
        }

        [TestMethod]
        public void TestCalculateBMRWithInvalidGender()
        {
            var result = calculator.CalculateBMR(70, 175, 30, "male", "Умеренная активность");

            var expectedCalories = 2034.8;
            var expectedProteins = 152.6;
            var expectedFats = 56.5;
            var expectedCarbohydrates = 228.9;

            Assert.AreEqual(expectedCalories, result.Calories, 0.1);
            Assert.AreEqual(expectedProteins, result.Proteins, 0.1);
            Assert.AreEqual(expectedFats, result.Fats, 0.1);
            Assert.AreEqual(expectedCarbohydrates, result.Carbohydrates, 0.1);
        }
    }
}
