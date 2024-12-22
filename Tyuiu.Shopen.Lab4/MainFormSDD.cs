using OrdinaryCalc.Lib;
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
    public partial class MainFormSDD : Form
    {

        private string currentOperation;
        private OrdinaryCalcLib calculator;
        private Stack<double> valuesStack;
        private Stack<string> operationsStack;



        public MainFormSDD()
        {
            InitializeComponent();
            calculator = new OrdinaryCalcLib();
            valuesStack = new Stack<double>();
            operationsStack = new Stack<string>();
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
        private void AppendDigit(string digit)
        {
            if (textBoxShowResultSDD.Text == "0" && digit != ",")
            {
                textBoxShowResultSDD.Text = digit;
            }
            else
            {
                textBoxShowResultSDD.Text += digit;
            }
        }

        private void ClearAll()
        {
            textBoxShowResultSDD.Clear();
            currentOperation = string.Empty;
            valuesStack.Clear();
            operationsStack.Clear();
        }
        private double PerformOperation(string operation, double value1, double value2)
        {
            switch (operation)
            {
                case "+":
                    return calculator.CalcSumma(value1, value2);
                case "-":
                    return calculator.CalcDifference(value1, value2);
                case "*":
                    return calculator.CalcMultiplication(value1, value2);
                case "/":
                    return calculator.CalcQuotient(value1, value2);
                case "+-":
                    return -value1;
                case "%":
                    return calculator.CalcPercentage(value1);
                case "sqrt":
                    return calculator.CalcSquareRoot(value1);
                case "square":
                    return calculator.CalcSquare(value1);
                case "rec":
                    return calculator.CalcReciprocal(value1);
                
                default:
                    throw new InvalidOperationException("Неизвестная операция");
            }
        }
        private void CalculateResult()
        {
            if (!string.IsNullOrWhiteSpace(textBoxShowResultSDD.Text) && textBoxShowResultSDD.Text != "-"){ 
                double currentValue = Convert.ToDouble(textBoxShowResultSDD.Text);
                valuesStack.Push(currentValue);

                while (operationsStack.Count > 0)
                {
                    string operation = operationsStack.Pop();
                    double value2 = valuesStack.Pop();
                    double value1 = valuesStack.Pop();
                    double result = PerformOperation(operation, value1, value2);
                    valuesStack.Push(result);
                }

                double finalResult = valuesStack.Pop();
                textBoxShowResultSDD.Text = finalResult.ToString();
            }
        }

        private void buttonNumberZeroSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void buttonNumberOneSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void buttonNumberTwoSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void buttonNumberThreeSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void buttonNumberFourSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void buttonNumberFiveSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void buttonNumberSixSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void buttonNumberSevenSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void buttonNumberEightSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void buttonNumberNineSDD_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void buttonDecimalSDD_Click(object sender, EventArgs e)
        {
            if (!textBoxShowResultSDD.Text.Contains(","))
            {
                textBoxShowResultSDD.Text += ",";
            }
        }
        private void PushOperation(string operation)
        {
            
            if (double.TryParse(textBoxShowResultSDD.Text, out double currentValue))
            {
                valuesStack.Push(currentValue);
                operationsStack.Push(operation);
                textBoxShowResultSDD.Text = "0";
            }
            else if (operation == "-")
            {
                textBoxShowResultSDD.Text = "-";
            }
            

        }

        private void buttonAddSDD_Click(object sender, EventArgs e)
        {
            PushOperation("+");
        }

        private void buttonSubtractSDD_Click(object sender, EventArgs e)
        {
            PushOperation("-");
        }

        private void buttonMultiplySDD_Click(object sender, EventArgs e)
        {
            PushOperation("*");
        }

        private void buttonDivideSDD_Click(object sender, EventArgs e)
        {
            PushOperation("/");
        }

        private void buttonPercentSDD_Click(object sender, EventArgs e)
        {
            PushOperation("%");
        }

        private void buttonPlusMinusSDD_Click(object sender, EventArgs e)
        {
            PushOperation("+-");
            CalculateResult();
        }

        private void buttonSquareRootSDD_Click(object sender, EventArgs e)
        {
            PushOperation("sqrt");
            CalculateResult();
        }

        private void buttonSquareSDD_Click(object sender, EventArgs e)
        {
            PushOperation("square");
            CalculateResult();
        }

        private void buttonInverseSDD_Click(object sender, EventArgs e)
        {
            PushOperation("rec");
            CalculateResult();
        }

        private void buttonBackspaceSDD_Click(object sender, EventArgs e)
        {
            if (textBoxShowResultSDD.Text.Length > 0)
            {
                textBoxShowResultSDD.Text = textBoxShowResultSDD.Text.Substring(0, textBoxShowResultSDD.Text.Length - 1);
            }
        }

        private void buttonClearSDD_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonEqualSSD_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        
    }
}
