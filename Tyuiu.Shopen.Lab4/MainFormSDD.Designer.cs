namespace Tyuiu.Shopen.Lab4
{
    partial class MainFormSDD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormSDD));
            this.menuStripTypeOFCalcSDD = new System.Windows.Forms.ToolStrip();
            this.ToolStripMenuItemTypeSDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemOrdinarySDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArithmeticSDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConversionSDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFitnessSDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfoSDD = new System.Windows.Forms.ToolStripButton();
            this.textBoxShowResultSDD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBackspaceSDD = new System.Windows.Forms.Button();
            this.buttonEqualSSD = new System.Windows.Forms.Button();
            this.buttonDecimalSDD = new System.Windows.Forms.Button();
            this.buttonNumberZeroSDD = new System.Windows.Forms.Button();
            this.buttonPlusMinusSDD = new System.Windows.Forms.Button();
            this.buttonAddSDD = new System.Windows.Forms.Button();
            this.buttonNumberThreeSDD = new System.Windows.Forms.Button();
            this.buttonNumberTwoSDD = new System.Windows.Forms.Button();
            this.buttonNumberOneSDD = new System.Windows.Forms.Button();
            this.buttonSubtractSDD = new System.Windows.Forms.Button();
            this.buttonNumberSixSDD = new System.Windows.Forms.Button();
            this.buttonNumberFiveSDD = new System.Windows.Forms.Button();
            this.buttonNumberFourSDD = new System.Windows.Forms.Button();
            this.buttonMultiplySDD = new System.Windows.Forms.Button();
            this.buttonNumberNineSDD = new System.Windows.Forms.Button();
            this.buttonNumberEightSDD = new System.Windows.Forms.Button();
            this.buttonNumberSevenSDD = new System.Windows.Forms.Button();
            this.buttonDivideSDD = new System.Windows.Forms.Button();
            this.buttonSquareRootSDD = new System.Windows.Forms.Button();
            this.buttonSquareSDD = new System.Windows.Forms.Button();
            this.buttonInverseSDD = new System.Windows.Forms.Button();
            this.buttonClearSDD = new System.Windows.Forms.Button();
            this.buttonPercentSDD = new System.Windows.Forms.Button();
            this.menuStripTypeOFCalcSDD.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTypeOFCalcSDD
            // 
            this.menuStripTypeOFCalcSDD.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTypeOFCalcSDD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTypeSDD,
            this.ToolStripMenuItemInfoSDD});
            this.menuStripTypeOFCalcSDD.Location = new System.Drawing.Point(0, 0);
            this.menuStripTypeOFCalcSDD.Name = "menuStripTypeOFCalcSDD";
            this.menuStripTypeOFCalcSDD.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.menuStripTypeOFCalcSDD.Size = new System.Drawing.Size(513, 34);
            this.menuStripTypeOFCalcSDD.TabIndex = 0;
            this.menuStripTypeOFCalcSDD.Text = "toolStrip1";
            // 
            // ToolStripMenuItemTypeSDD
            // 
            this.ToolStripMenuItemTypeSDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItemTypeSDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOrdinarySDD,
            this.ToolStripMenuItemArithmeticSDD,
            this.ToolStripMenuItemConversionSDD,
            this.ToolStripMenuItemFitnessSDD});
            this.ToolStripMenuItemTypeSDD.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemTypeSDD.Image")));
            this.ToolStripMenuItemTypeSDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItemTypeSDD.Name = "ToolStripMenuItemTypeSDD";
            this.ToolStripMenuItemTypeSDD.Size = new System.Drawing.Size(59, 29);
            this.ToolStripMenuItemTypeSDD.Text = "Тип";
            // 
            // ToolStripMenuItemOrdinarySDD
            // 
            this.ToolStripMenuItemOrdinarySDD.Enabled = false;
            this.ToolStripMenuItemOrdinarySDD.Name = "ToolStripMenuItemOrdinarySDD";
            this.ToolStripMenuItemOrdinarySDD.Size = new System.Drawing.Size(252, 34);
            this.ToolStripMenuItemOrdinarySDD.Text = "Стандартный";
            // 
            // ToolStripMenuItemArithmeticSDD
            // 
            this.ToolStripMenuItemArithmeticSDD.Name = "ToolStripMenuItemArithmeticSDD";
            this.ToolStripMenuItemArithmeticSDD.Size = new System.Drawing.Size(252, 34);
            this.ToolStripMenuItemArithmeticSDD.Text = "Расширенный";
            this.ToolStripMenuItemArithmeticSDD.Click += new System.EventHandler(this.ToolStripMenuItemArithmeticSDD_Click);
            // 
            // ToolStripMenuItemConversionSDD
            // 
            this.ToolStripMenuItemConversionSDD.Name = "ToolStripMenuItemConversionSDD";
            this.ToolStripMenuItemConversionSDD.Size = new System.Drawing.Size(252, 34);
            this.ToolStripMenuItemConversionSDD.Text = "Перевод единиц";
            this.ToolStripMenuItemConversionSDD.Click += new System.EventHandler(this.ToolStripMenuItemConversionSDD_Click);
            // 
            // ToolStripMenuItemFitnessSDD
            // 
            this.ToolStripMenuItemFitnessSDD.Name = "ToolStripMenuItemFitnessSDD";
            this.ToolStripMenuItemFitnessSDD.Size = new System.Drawing.Size(252, 34);
            this.ToolStripMenuItemFitnessSDD.Text = "Фитнес";
            this.ToolStripMenuItemFitnessSDD.Click += new System.EventHandler(this.ToolStripMenuItemFitnessSDD_Click);
            // 
            // ToolStripMenuItemInfoSDD
            // 
            this.ToolStripMenuItemInfoSDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripMenuItemInfoSDD.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemInfoSDD.Image")));
            this.ToolStripMenuItemInfoSDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripMenuItemInfoSDD.Name = "ToolStripMenuItemInfoSDD";
            this.ToolStripMenuItemInfoSDD.Size = new System.Drawing.Size(85, 29);
            this.ToolStripMenuItemInfoSDD.Text = "Справка";
            this.ToolStripMenuItemInfoSDD.Click += new System.EventHandler(this.ToolStripMenuItemInfoSDD_Click);
            // 
            // textBoxShowResultSDD
            // 
            this.textBoxShowResultSDD.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxShowResultSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.textBoxShowResultSDD.Location = new System.Drawing.Point(0, 34);
            this.textBoxShowResultSDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShowResultSDD.Multiline = true;
            this.textBoxShowResultSDD.Name = "textBoxShowResultSDD";
            this.textBoxShowResultSDD.ReadOnly = true;
            this.textBoxShowResultSDD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxShowResultSDD.Size = new System.Drawing.Size(513, 100);
            this.textBoxShowResultSDD.TabIndex = 1;
            this.textBoxShowResultSDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonBackspaceSDD, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqualSSD, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonDecimalSDD, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberZeroSDD, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlusMinusSDD, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddSDD, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberThreeSDD, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberTwoSDD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberOneSDD, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonSubtractSDD, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberSixSDD, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberFiveSDD, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberFourSDD, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiplySDD, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberNineSDD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberEightSDD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumberSevenSDD, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDivideSDD, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSquareRootSDD, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSquareSDD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonInverseSDD, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonClearSDD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPercentSDD, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 540);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // buttonBackspaceSDD
            // 
            this.buttonBackspaceSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonBackspaceSDD, 2);
            this.buttonBackspaceSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBackspaceSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonBackspaceSDD.Location = new System.Drawing.Point(259, 3);
            this.buttonBackspaceSDD.Name = "buttonBackspaceSDD";
            this.buttonBackspaceSDD.Size = new System.Drawing.Size(251, 84);
            this.buttonBackspaceSDD.TabIndex = 24;
            this.buttonBackspaceSDD.Text = "←";
            this.buttonBackspaceSDD.UseVisualStyleBackColor = false;
            this.buttonBackspaceSDD.Click += new System.EventHandler(this.buttonBackspaceSDD_Click);
            // 
            // buttonEqualSSD
            // 
            this.buttonEqualSSD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEqualSSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqualSSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonEqualSSD.Location = new System.Drawing.Point(387, 453);
            this.buttonEqualSSD.Name = "buttonEqualSSD";
            this.buttonEqualSSD.Size = new System.Drawing.Size(123, 84);
            this.buttonEqualSSD.TabIndex = 23;
            this.buttonEqualSSD.Text = "=";
            this.buttonEqualSSD.UseVisualStyleBackColor = false;
            this.buttonEqualSSD.Click += new System.EventHandler(this.buttonEqualSSD_Click);
            // 
            // buttonDecimalSDD
            // 
            this.buttonDecimalSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDecimalSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDecimalSDD.Location = new System.Drawing.Point(259, 453);
            this.buttonDecimalSDD.Name = "buttonDecimalSDD";
            this.buttonDecimalSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonDecimalSDD.TabIndex = 22;
            this.buttonDecimalSDD.Text = ",";
            this.buttonDecimalSDD.UseVisualStyleBackColor = true;
            this.buttonDecimalSDD.Click += new System.EventHandler(this.buttonDecimalSDD_Click);
            // 
            // buttonNumberZeroSDD
            // 
            this.buttonNumberZeroSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberZeroSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberZeroSDD.Location = new System.Drawing.Point(131, 453);
            this.buttonNumberZeroSDD.Name = "buttonNumberZeroSDD";
            this.buttonNumberZeroSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberZeroSDD.TabIndex = 21;
            this.buttonNumberZeroSDD.Text = "0";
            this.buttonNumberZeroSDD.UseVisualStyleBackColor = true;
            this.buttonNumberZeroSDD.Click += new System.EventHandler(this.buttonNumberZeroSDD_Click);
            // 
            // buttonPlusMinusSDD
            // 
            this.buttonPlusMinusSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlusMinusSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPlusMinusSDD.Location = new System.Drawing.Point(3, 453);
            this.buttonPlusMinusSDD.Name = "buttonPlusMinusSDD";
            this.buttonPlusMinusSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonPlusMinusSDD.TabIndex = 20;
            this.buttonPlusMinusSDD.Text = "±";
            this.buttonPlusMinusSDD.UseVisualStyleBackColor = true;
            this.buttonPlusMinusSDD.Click += new System.EventHandler(this.buttonPlusMinusSDD_Click);
            // 
            // buttonAddSDD
            // 
            this.buttonAddSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonAddSDD.Location = new System.Drawing.Point(387, 363);
            this.buttonAddSDD.Name = "buttonAddSDD";
            this.buttonAddSDD.Size = new System.Drawing.Size(123, 84);
            this.buttonAddSDD.TabIndex = 19;
            this.buttonAddSDD.Text = "+";
            this.buttonAddSDD.UseVisualStyleBackColor = false;
            this.buttonAddSDD.Click += new System.EventHandler(this.buttonAddSDD_Click);
            // 
            // buttonNumberThreeSDD
            // 
            this.buttonNumberThreeSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberThreeSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberThreeSDD.Location = new System.Drawing.Point(259, 363);
            this.buttonNumberThreeSDD.Name = "buttonNumberThreeSDD";
            this.buttonNumberThreeSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberThreeSDD.TabIndex = 18;
            this.buttonNumberThreeSDD.Text = "3";
            this.buttonNumberThreeSDD.UseVisualStyleBackColor = true;
            this.buttonNumberThreeSDD.Click += new System.EventHandler(this.buttonNumberThreeSDD_Click);
            // 
            // buttonNumberTwoSDD
            // 
            this.buttonNumberTwoSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberTwoSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberTwoSDD.Location = new System.Drawing.Point(131, 363);
            this.buttonNumberTwoSDD.Name = "buttonNumberTwoSDD";
            this.buttonNumberTwoSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberTwoSDD.TabIndex = 17;
            this.buttonNumberTwoSDD.Text = "2";
            this.buttonNumberTwoSDD.UseVisualStyleBackColor = true;
            this.buttonNumberTwoSDD.Click += new System.EventHandler(this.buttonNumberTwoSDD_Click);
            // 
            // buttonNumberOneSDD
            // 
            this.buttonNumberOneSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberOneSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberOneSDD.Location = new System.Drawing.Point(3, 363);
            this.buttonNumberOneSDD.Name = "buttonNumberOneSDD";
            this.buttonNumberOneSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberOneSDD.TabIndex = 16;
            this.buttonNumberOneSDD.Text = "1";
            this.buttonNumberOneSDD.UseVisualStyleBackColor = true;
            this.buttonNumberOneSDD.Click += new System.EventHandler(this.buttonNumberOneSDD_Click);
            // 
            // buttonSubtractSDD
            // 
            this.buttonSubtractSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSubtractSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubtractSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonSubtractSDD.Location = new System.Drawing.Point(387, 273);
            this.buttonSubtractSDD.Name = "buttonSubtractSDD";
            this.buttonSubtractSDD.Size = new System.Drawing.Size(123, 84);
            this.buttonSubtractSDD.TabIndex = 15;
            this.buttonSubtractSDD.Text = "-";
            this.buttonSubtractSDD.UseVisualStyleBackColor = false;
            this.buttonSubtractSDD.Click += new System.EventHandler(this.buttonSubtractSDD_Click);
            // 
            // buttonNumberSixSDD
            // 
            this.buttonNumberSixSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberSixSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberSixSDD.Location = new System.Drawing.Point(259, 273);
            this.buttonNumberSixSDD.Name = "buttonNumberSixSDD";
            this.buttonNumberSixSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberSixSDD.TabIndex = 14;
            this.buttonNumberSixSDD.Text = "6";
            this.buttonNumberSixSDD.UseVisualStyleBackColor = true;
            this.buttonNumberSixSDD.Click += new System.EventHandler(this.buttonNumberSixSDD_Click);
            // 
            // buttonNumberFiveSDD
            // 
            this.buttonNumberFiveSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberFiveSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberFiveSDD.Location = new System.Drawing.Point(131, 273);
            this.buttonNumberFiveSDD.Name = "buttonNumberFiveSDD";
            this.buttonNumberFiveSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberFiveSDD.TabIndex = 13;
            this.buttonNumberFiveSDD.Text = "5";
            this.buttonNumberFiveSDD.UseVisualStyleBackColor = true;
            this.buttonNumberFiveSDD.Click += new System.EventHandler(this.buttonNumberFiveSDD_Click);
            // 
            // buttonNumberFourSDD
            // 
            this.buttonNumberFourSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberFourSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberFourSDD.Location = new System.Drawing.Point(3, 273);
            this.buttonNumberFourSDD.Name = "buttonNumberFourSDD";
            this.buttonNumberFourSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberFourSDD.TabIndex = 12;
            this.buttonNumberFourSDD.Text = "4";
            this.buttonNumberFourSDD.UseVisualStyleBackColor = true;
            this.buttonNumberFourSDD.Click += new System.EventHandler(this.buttonNumberFourSDD_Click);
            // 
            // buttonMultiplySDD
            // 
            this.buttonMultiplySDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMultiplySDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiplySDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonMultiplySDD.Location = new System.Drawing.Point(387, 183);
            this.buttonMultiplySDD.Name = "buttonMultiplySDD";
            this.buttonMultiplySDD.Size = new System.Drawing.Size(123, 84);
            this.buttonMultiplySDD.TabIndex = 11;
            this.buttonMultiplySDD.Text = "×";
            this.buttonMultiplySDD.UseVisualStyleBackColor = false;
            this.buttonMultiplySDD.Click += new System.EventHandler(this.buttonMultiplySDD_Click);
            // 
            // buttonNumberNineSDD
            // 
            this.buttonNumberNineSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberNineSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberNineSDD.Location = new System.Drawing.Point(259, 183);
            this.buttonNumberNineSDD.Name = "buttonNumberNineSDD";
            this.buttonNumberNineSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberNineSDD.TabIndex = 10;
            this.buttonNumberNineSDD.Text = "9";
            this.buttonNumberNineSDD.UseVisualStyleBackColor = true;
            this.buttonNumberNineSDD.Click += new System.EventHandler(this.buttonNumberNineSDD_Click);
            // 
            // buttonNumberEightSDD
            // 
            this.buttonNumberEightSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberEightSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberEightSDD.Location = new System.Drawing.Point(131, 183);
            this.buttonNumberEightSDD.Name = "buttonNumberEightSDD";
            this.buttonNumberEightSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberEightSDD.TabIndex = 9;
            this.buttonNumberEightSDD.Text = "8";
            this.buttonNumberEightSDD.UseVisualStyleBackColor = true;
            this.buttonNumberEightSDD.Click += new System.EventHandler(this.buttonNumberEightSDD_Click);
            // 
            // buttonNumberSevenSDD
            // 
            this.buttonNumberSevenSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumberSevenSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonNumberSevenSDD.Location = new System.Drawing.Point(3, 183);
            this.buttonNumberSevenSDD.Name = "buttonNumberSevenSDD";
            this.buttonNumberSevenSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonNumberSevenSDD.TabIndex = 8;
            this.buttonNumberSevenSDD.Text = "7";
            this.buttonNumberSevenSDD.UseVisualStyleBackColor = true;
            this.buttonNumberSevenSDD.Click += new System.EventHandler(this.buttonNumberSevenSDD_Click);
            // 
            // buttonDivideSDD
            // 
            this.buttonDivideSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDivideSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivideSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDivideSDD.Location = new System.Drawing.Point(387, 93);
            this.buttonDivideSDD.Name = "buttonDivideSDD";
            this.buttonDivideSDD.Size = new System.Drawing.Size(123, 84);
            this.buttonDivideSDD.TabIndex = 7;
            this.buttonDivideSDD.Text = "÷";
            this.buttonDivideSDD.UseVisualStyleBackColor = false;
            this.buttonDivideSDD.Click += new System.EventHandler(this.buttonDivideSDD_Click);
            // 
            // buttonSquareRootSDD
            // 
            this.buttonSquareRootSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSquareRootSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSquareRootSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonSquareRootSDD.Location = new System.Drawing.Point(259, 93);
            this.buttonSquareRootSDD.Name = "buttonSquareRootSDD";
            this.buttonSquareRootSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonSquareRootSDD.TabIndex = 6;
            this.buttonSquareRootSDD.Text = "√ ";
            this.buttonSquareRootSDD.UseVisualStyleBackColor = false;
            this.buttonSquareRootSDD.Click += new System.EventHandler(this.buttonSquareRootSDD_Click);
            // 
            // buttonSquareSDD
            // 
            this.buttonSquareSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSquareSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSquareSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonSquareSDD.Location = new System.Drawing.Point(131, 93);
            this.buttonSquareSDD.Name = "buttonSquareSDD";
            this.buttonSquareSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonSquareSDD.TabIndex = 5;
            this.buttonSquareSDD.Text = "x²";
            this.buttonSquareSDD.UseVisualStyleBackColor = false;
            this.buttonSquareSDD.Click += new System.EventHandler(this.buttonSquareSDD_Click);
            // 
            // buttonInverseSDD
            // 
            this.buttonInverseSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonInverseSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInverseSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonInverseSDD.Location = new System.Drawing.Point(3, 93);
            this.buttonInverseSDD.Name = "buttonInverseSDD";
            this.buttonInverseSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonInverseSDD.TabIndex = 4;
            this.buttonInverseSDD.Text = "1/x";
            this.buttonInverseSDD.UseVisualStyleBackColor = false;
            this.buttonInverseSDD.Click += new System.EventHandler(this.buttonInverseSDD_Click);
            // 
            // buttonClearSDD
            // 
            this.buttonClearSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClearSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonClearSDD.Location = new System.Drawing.Point(131, 3);
            this.buttonClearSDD.Name = "buttonClearSDD";
            this.buttonClearSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonClearSDD.TabIndex = 1;
            this.buttonClearSDD.Text = "C";
            this.buttonClearSDD.UseVisualStyleBackColor = false;
            this.buttonClearSDD.Click += new System.EventHandler(this.buttonClearSDD_Click);
            // 
            // buttonPercentSDD
            // 
            this.buttonPercentSDD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPercentSDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPercentSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonPercentSDD.Location = new System.Drawing.Point(3, 3);
            this.buttonPercentSDD.Name = "buttonPercentSDD";
            this.buttonPercentSDD.Size = new System.Drawing.Size(122, 84);
            this.buttonPercentSDD.TabIndex = 0;
            this.buttonPercentSDD.Text = "%";
            this.buttonPercentSDD.UseVisualStyleBackColor = false;
            this.buttonPercentSDD.Click += new System.EventHandler(this.buttonPercentSDD_Click);
            // 
            // MainFormSDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxShowResultSDD);
            this.Controls.Add(this.menuStripTypeOFCalcSDD);
            this.Name = "MainFormSDD";
            this.Text = "Калькулятор SDD";
            this.menuStripTypeOFCalcSDD.ResumeLayout(false);
            this.menuStripTypeOFCalcSDD.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuStripTypeOFCalcSDD;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripMenuItemTypeSDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOrdinarySDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArithmeticSDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConversionSDD;
        private System.Windows.Forms.ToolStripButton ToolStripMenuItemInfoSDD;
        private System.Windows.Forms.TextBox textBoxShowResultSDD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPercentSDD;
        private System.Windows.Forms.Button buttonEqualSSD;
        private System.Windows.Forms.Button buttonDecimalSDD;
        private System.Windows.Forms.Button buttonNumberZeroSDD;
        private System.Windows.Forms.Button buttonPlusMinusSDD;
        private System.Windows.Forms.Button buttonAddSDD;
        private System.Windows.Forms.Button buttonNumberThreeSDD;
        private System.Windows.Forms.Button buttonNumberTwoSDD;
        private System.Windows.Forms.Button buttonNumberOneSDD;
        private System.Windows.Forms.Button buttonSubtractSDD;
        private System.Windows.Forms.Button buttonNumberSixSDD;
        private System.Windows.Forms.Button buttonNumberFiveSDD;
        private System.Windows.Forms.Button buttonNumberFourSDD;
        private System.Windows.Forms.Button buttonMultiplySDD;
        private System.Windows.Forms.Button buttonNumberNineSDD;
        private System.Windows.Forms.Button buttonNumberEightSDD;
        private System.Windows.Forms.Button buttonNumberSevenSDD;
        private System.Windows.Forms.Button buttonDivideSDD;
        private System.Windows.Forms.Button buttonSquareRootSDD;
        private System.Windows.Forms.Button buttonSquareSDD;
        private System.Windows.Forms.Button buttonInverseSDD;
        private System.Windows.Forms.Button buttonClearSDD;
        private System.Windows.Forms.Button buttonBackspaceSDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFitnessSDD;
    }
}

