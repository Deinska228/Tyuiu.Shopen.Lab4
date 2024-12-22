using FitnessCalc.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.Shopen.Lab4
{
    public partial class FitnessFormSDD : Form
    {
        public FitnessFormSDD()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemOrdinarySDD_Click(object sender, EventArgs e)
        {
            MainFormSDD mainForm = new MainFormSDD();
            mainForm.Show();
            this.Hide();
        }

        private void ToolStripMenuItemArithmeticSDD_Click(object sender, EventArgs e)
        {
            ArithmeticFormSDD arithmeticForm = new ArithmeticFormSDD();
            arithmeticForm.Show();
            this.Hide();
        }

        private void ToolStripMenuItemConversionSDD_Click(object sender, EventArgs e)
        {
            ConversionFormSDD сonversionForm = new ConversionFormSDD();
            сonversionForm.Show();
            this.Hide();
        }

        private void ToolStripMenuItemInfoSDD_Click(object sender, EventArgs e)
        {
            InfoFormSDD infoFormSDD = new InfoFormSDD();
            infoFormSDD.Show();
        }
        private void buttonCalculateFitnessSDD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEnterWeightSDD.Text) ||
                string.IsNullOrWhiteSpace(textBoxEnterHeightSDD.Text) ||
                string.IsNullOrWhiteSpace(textBoxEnterAgeSDD.Text) ||
                comboBoxChooseActivityLevelSDD.SelectedItem == null)
            {
                return;
            }
            double weightKg = double.Parse(textBoxEnterWeightSDD.Text);
            double heightCm = double.Parse(textBoxEnterHeightSDD.Text);
            int age = int.Parse(textBoxEnterAgeSDD.Text);

            string gender = radioButtonChooseGenderMaleSDD.Checked ? "male" : "female";

            string selectedActivityLabel = comboBoxChooseActivityLevelSDD.SelectedItem.ToString();

            FitnessCalcLib fitnessCalc = new FitnessCalcLib();

            double bmi = fitnessCalc.CalculateBMI(weightKg, heightCm / 100);

            var bmrResult = fitnessCalc.CalculateBMR(weightKg, heightCm, age, gender, selectedActivityLabel);

            textBoxShowResultSDD.Text = $"BMI: {bmi:F2}\r\n" +
                                        $"Калории: {bmrResult.Calories:F2}\r\n" +
                                        $"Белки: {bmrResult.Proteins:F2} г\r\n" +
                                        $"Жиры: {bmrResult.Fats:F2} г\r\n" +
                                        $"Углеводы: {bmrResult.Carbohydrates:F2} г";
        }

        
    }
}
