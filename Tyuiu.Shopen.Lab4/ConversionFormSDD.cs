using ConversionCalc.Lib;
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
    public partial class ConversionFormSDD : Form
    {
        private ConversionCalcLib conversionCalc;
        public ConversionFormSDD()
        {
            InitializeComponent();
            conversionCalc = new ConversionCalcLib();
            comboBoxChooseInLengthSDD.SelectedIndex = 0;
            comboBoxChooseOutLengthSDD.SelectedIndex = 1;
            comboBoxChooseInWeightSDD.SelectedIndex = 0;
            comboBoxChooseOutWeightSDD.SelectedIndex = 1;
            comboBoxChooseInVolumeSDD.SelectedIndex = 0;
            comboBoxChooseOutVolumeSDD.SelectedIndex = 1;
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

        private void ToolStripMenuItemFitnessSDD_Click(object sender, EventArgs e)
        {
            FitnessFormSDD fitnessFormSDD = new FitnessFormSDD();
            fitnessFormSDD.Show();
            this.Hide();
        }

        private void ToolStripMenuItemInfoSDD_Click(object sender, EventArgs e)
        {
            InfoFormSDD infoFormSDD = new InfoFormSDD();
            infoFormSDD.Show();
        }
        private string GetUnitAbbreviation(string fullUnitName)
        {
            switch (fullUnitName)
            {
                case "Килограммы (kg)": return "kg";
                case "Граммы (grams)": return "g";
                case "Тонны (tons)": return "tons";
                case "Фунты (lbs)": return "lbs";
                case "Унции (oz)": return "oz";

                case "Метры (m)": return "m";
                case "Сантиметры (cm)": return "cm";
                case "Миллиметры (mm)": return "mm";
                case "Километры (km)": return "km";
                case "Футы (ft)": return "ft";
                case "Дюймы (in)": return "in";

                case "Литры (l)": return "l";
                case "Миллилитры (ml)": return "ml";
                case "Галлоны (gal)": return "gal";
                case "Кубические метры (m3)": return "m3";

                default: return string.Empty;
            }
        }


        private void CalculateConversion(ComboBox inUnitComboBox, ComboBox outUnitComboBox, TextBox inputTextBox, TextBox outputTextBox)
        {
            if (double.TryParse(inputTextBox.Text, out double inputValue))
            {
                string inUnit = inUnitComboBox.SelectedItem?.ToString() ?? string.Empty;
                string outUnit = outUnitComboBox.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(inUnit) || string.IsNullOrEmpty(outUnit))
                {
                    return;
                }

                inUnit = GetUnitAbbreviation(inUnit);
                outUnit = GetUnitAbbreviation(outUnit);

                try
                {
                    double result = conversionCalc.Convert(inputValue, inUnit, outUnit);
                    outputTextBox.Text = result.ToString();
                }
                catch (ArgumentException)
                {
                   return;
                }
            }
            else
            {
                return;
            }
        }
        private void buttonCalculateWeightSDD_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInWeightSDD, comboBoxChooseOutWeightSDD, textBoxInputWeightSDD, textBoxOutputWeightSDD);
        }

        private void buttonCalculateLengthSDD_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInLengthSDD, comboBoxChooseOutLengthSDD, textBoxInputLengthSDD, textBoxOutputLengthSDD);
        }

        private void buttonCalculateVolumeSDD_Click(object sender, EventArgs e)
        {
            CalculateConversion(comboBoxChooseInVolumeSDD, comboBoxChooseOutVolumeSDD, textBoxInputVolumeSDD, textBoxOutputVolumeSDD);
        }

        
    }
}
