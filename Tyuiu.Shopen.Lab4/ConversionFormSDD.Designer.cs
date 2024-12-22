namespace Tyuiu.Shopen.Lab4
{
    partial class ConversionFormSDD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionFormSDD));
            this.menuStripTypeOFCalcSDD = new System.Windows.Forms.ToolStrip();
            this.ToolStripMenuItemTypeSDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemOrdinarySDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemArithmeticSDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConversionSDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFitnessSDD = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfoSDD = new System.Windows.Forms.ToolStripButton();
            this.labelConversionWeightSDD = new System.Windows.Forms.Label();
            this.labelConversionLengthSDD = new System.Windows.Forms.Label();
            this.labelConversionVolumeSDD = new System.Windows.Forms.Label();
            this.textBoxInputWeightSDD = new System.Windows.Forms.TextBox();
            this.textBoxOutputWeightSDD = new System.Windows.Forms.TextBox();
            this.textBoxInputLengthSDD = new System.Windows.Forms.TextBox();
            this.textBoxOutputLengthSDD = new System.Windows.Forms.TextBox();
            this.textBoxInputVolumeSDD = new System.Windows.Forms.TextBox();
            this.textBoxOutputVolumeSDD = new System.Windows.Forms.TextBox();
            this.comboBoxChooseInWeightSDD = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseOutWeightSDD = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseOutLengthSDD = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseInLengthSDD = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseOutVolumeSDD = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseInVolumeSDD = new System.Windows.Forms.ComboBox();
            this.buttonCalculateVolumeSDD = new System.Windows.Forms.Button();
            this.buttonCalculateLengthSDD = new System.Windows.Forms.Button();
            this.buttonCalculateWeightSDD = new System.Windows.Forms.Button();
            this.menuStripTypeOFCalcSDD.SuspendLayout();
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
            this.menuStripTypeOFCalcSDD.TabIndex = 4;
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
            this.ToolStripMenuItemOrdinarySDD.Name = "ToolStripMenuItemOrdinarySDD";
            this.ToolStripMenuItemOrdinarySDD.Size = new System.Drawing.Size(252, 34);
            this.ToolStripMenuItemOrdinarySDD.Text = "Стандартный";
            this.ToolStripMenuItemOrdinarySDD.Click += new System.EventHandler(this.ToolStripMenuItemOrdinarySDD_Click);
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
            this.ToolStripMenuItemConversionSDD.Enabled = false;
            this.ToolStripMenuItemConversionSDD.Name = "ToolStripMenuItemConversionSDD";
            this.ToolStripMenuItemConversionSDD.Size = new System.Drawing.Size(252, 34);
            this.ToolStripMenuItemConversionSDD.Text = "Перевод единиц";
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
            // labelConversionWeightSDD
            // 
            this.labelConversionWeightSDD.AutoSize = true;
            this.labelConversionWeightSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelConversionWeightSDD.Location = new System.Drawing.Point(95, 63);
            this.labelConversionWeightSDD.Name = "labelConversionWeightSDD";
            this.labelConversionWeightSDD.Size = new System.Drawing.Size(348, 37);
            this.labelConversionWeightSDD.TabIndex = 5;
            this.labelConversionWeightSDD.Text = "Перевод единиц массы";
            // 
            // labelConversionLengthSDD
            // 
            this.labelConversionLengthSDD.AutoSize = true;
            this.labelConversionLengthSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelConversionLengthSDD.Location = new System.Drawing.Point(91, 258);
            this.labelConversionLengthSDD.Name = "labelConversionLengthSDD";
            this.labelConversionLengthSDD.Size = new System.Drawing.Size(340, 37);
            this.labelConversionLengthSDD.TabIndex = 6;
            this.labelConversionLengthSDD.Text = "Перевод единиц длины";
            // 
            // labelConversionVolumeSDD
            // 
            this.labelConversionVolumeSDD.AutoSize = true;
            this.labelConversionVolumeSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelConversionVolumeSDD.Location = new System.Drawing.Point(64, 454);
            this.labelConversionVolumeSDD.Name = "labelConversionVolumeSDD";
            this.labelConversionVolumeSDD.Size = new System.Drawing.Size(364, 37);
            this.labelConversionVolumeSDD.TabIndex = 7;
            this.labelConversionVolumeSDD.Text = "Перевод единиц объема";
            // 
            // textBoxInputWeightSDD
            // 
            this.textBoxInputWeightSDD.Location = new System.Drawing.Point(68, 127);
            this.textBoxInputWeightSDD.Name = "textBoxInputWeightSDD";
            this.textBoxInputWeightSDD.Size = new System.Drawing.Size(100, 26);
            this.textBoxInputWeightSDD.TabIndex = 8;
            // 
            // textBoxOutputWeightSDD
            // 
            this.textBoxOutputWeightSDD.Location = new System.Drawing.Point(331, 127);
            this.textBoxOutputWeightSDD.Name = "textBoxOutputWeightSDD";
            this.textBoxOutputWeightSDD.ReadOnly = true;
            this.textBoxOutputWeightSDD.Size = new System.Drawing.Size(100, 26);
            this.textBoxOutputWeightSDD.TabIndex = 9;
            // 
            // textBoxInputLengthSDD
            // 
            this.textBoxInputLengthSDD.Location = new System.Drawing.Point(68, 337);
            this.textBoxInputLengthSDD.Name = "textBoxInputLengthSDD";
            this.textBoxInputLengthSDD.Size = new System.Drawing.Size(100, 26);
            this.textBoxInputLengthSDD.TabIndex = 10;
            // 
            // textBoxOutputLengthSDD
            // 
            this.textBoxOutputLengthSDD.Location = new System.Drawing.Point(331, 337);
            this.textBoxOutputLengthSDD.Name = "textBoxOutputLengthSDD";
            this.textBoxOutputLengthSDD.ReadOnly = true;
            this.textBoxOutputLengthSDD.Size = new System.Drawing.Size(100, 26);
            this.textBoxOutputLengthSDD.TabIndex = 11;
            // 
            // textBoxInputVolumeSDD
            // 
            this.textBoxInputVolumeSDD.Location = new System.Drawing.Point(68, 526);
            this.textBoxInputVolumeSDD.Name = "textBoxInputVolumeSDD";
            this.textBoxInputVolumeSDD.Size = new System.Drawing.Size(100, 26);
            this.textBoxInputVolumeSDD.TabIndex = 12;
            // 
            // textBoxOutputVolumeSDD
            // 
            this.textBoxOutputVolumeSDD.Location = new System.Drawing.Point(331, 526);
            this.textBoxOutputVolumeSDD.Name = "textBoxOutputVolumeSDD";
            this.textBoxOutputVolumeSDD.ReadOnly = true;
            this.textBoxOutputVolumeSDD.Size = new System.Drawing.Size(100, 26);
            this.textBoxOutputVolumeSDD.TabIndex = 13;
            // 
            // comboBoxChooseInWeightSDD
            // 
            this.comboBoxChooseInWeightSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseInWeightSDD.FormattingEnabled = true;
            this.comboBoxChooseInWeightSDD.Items.AddRange(new object[] {
            "Килограммы (kg)",
            "Граммы (grams)",
            "Тонны (tons)",
            "Фунты (lbs)",
            "Унции (oz)"});
            this.comboBoxChooseInWeightSDD.Location = new System.Drawing.Point(18, 183);
            this.comboBoxChooseInWeightSDD.Name = "comboBoxChooseInWeightSDD";
            this.comboBoxChooseInWeightSDD.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseInWeightSDD.TabIndex = 14;
            // 
            // comboBoxChooseOutWeightSDD
            // 
            this.comboBoxChooseOutWeightSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseOutWeightSDD.FormattingEnabled = true;
            this.comboBoxChooseOutWeightSDD.Items.AddRange(new object[] {
            "Килограммы (kg)",
            "Граммы (grams)",
            "Тонны (tons)",
            "Фунты (lbs)",
            "Унции (oz)"});
            this.comboBoxChooseOutWeightSDD.Location = new System.Drawing.Point(281, 183);
            this.comboBoxChooseOutWeightSDD.Name = "comboBoxChooseOutWeightSDD";
            this.comboBoxChooseOutWeightSDD.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseOutWeightSDD.TabIndex = 15;
            // 
            // comboBoxChooseOutLengthSDD
            // 
            this.comboBoxChooseOutLengthSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseOutLengthSDD.FormattingEnabled = true;
            this.comboBoxChooseOutLengthSDD.Items.AddRange(new object[] {
            "Метры (m)",
            "Сантиметры (cm)",
            "Миллиметры (mm)",
            "Километры (km)",
            "Футы (ft)",
            "Дюймы (in)"});
            this.comboBoxChooseOutLengthSDD.Location = new System.Drawing.Point(281, 396);
            this.comboBoxChooseOutLengthSDD.Name = "comboBoxChooseOutLengthSDD";
            this.comboBoxChooseOutLengthSDD.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseOutLengthSDD.TabIndex = 17;
            // 
            // comboBoxChooseInLengthSDD
            // 
            this.comboBoxChooseInLengthSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseInLengthSDD.FormattingEnabled = true;
            this.comboBoxChooseInLengthSDD.Items.AddRange(new object[] {
            "Метры (m)",
            "Сантиметры (cm)",
            "Миллиметры (mm)",
            "Километры (km)",
            "Футы (ft)",
            "Дюймы (in)"});
            this.comboBoxChooseInLengthSDD.Location = new System.Drawing.Point(18, 396);
            this.comboBoxChooseInLengthSDD.Name = "comboBoxChooseInLengthSDD";
            this.comboBoxChooseInLengthSDD.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseInLengthSDD.TabIndex = 16;
            // 
            // comboBoxChooseOutVolumeSDD
            // 
            this.comboBoxChooseOutVolumeSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseOutVolumeSDD.FormattingEnabled = true;
            this.comboBoxChooseOutVolumeSDD.Items.AddRange(new object[] {
            "Литры (l)",
            "Миллилитры (ml)",
            "Галлоны (gal)",
            "Кубические метры (m3)"});
            this.comboBoxChooseOutVolumeSDD.Location = new System.Drawing.Point(281, 568);
            this.comboBoxChooseOutVolumeSDD.Name = "comboBoxChooseOutVolumeSDD";
            this.comboBoxChooseOutVolumeSDD.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseOutVolumeSDD.TabIndex = 19;
            // 
            // comboBoxChooseInVolumeSDD
            // 
            this.comboBoxChooseInVolumeSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseInVolumeSDD.FormattingEnabled = true;
            this.comboBoxChooseInVolumeSDD.Items.AddRange(new object[] {
            "Литры (l)",
            "Миллилитры (ml)",
            "Галлоны (gal)",
            "Кубические метры (m3)"});
            this.comboBoxChooseInVolumeSDD.Location = new System.Drawing.Point(18, 568);
            this.comboBoxChooseInVolumeSDD.Name = "comboBoxChooseInVolumeSDD";
            this.comboBoxChooseInVolumeSDD.Size = new System.Drawing.Size(200, 28);
            this.comboBoxChooseInVolumeSDD.TabIndex = 18;
            // 
            // buttonCalculateVolumeSDD
            // 
            this.buttonCalculateVolumeSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalculateVolumeSDD.Location = new System.Drawing.Point(198, 510);
            this.buttonCalculateVolumeSDD.Name = "buttonCalculateVolumeSDD";
            this.buttonCalculateVolumeSDD.Size = new System.Drawing.Size(100, 50);
            this.buttonCalculateVolumeSDD.TabIndex = 22;
            this.buttonCalculateVolumeSDD.Text = "=";
            this.buttonCalculateVolumeSDD.UseVisualStyleBackColor = true;
            this.buttonCalculateVolumeSDD.Click += new System.EventHandler(this.buttonCalculateVolumeSDD_Click);
            // 
            // buttonCalculateLengthSDD
            // 
            this.buttonCalculateLengthSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalculateLengthSDD.Location = new System.Drawing.Point(198, 321);
            this.buttonCalculateLengthSDD.Name = "buttonCalculateLengthSDD";
            this.buttonCalculateLengthSDD.Size = new System.Drawing.Size(100, 50);
            this.buttonCalculateLengthSDD.TabIndex = 23;
            this.buttonCalculateLengthSDD.Text = "=";
            this.buttonCalculateLengthSDD.UseVisualStyleBackColor = true;
            this.buttonCalculateLengthSDD.Click += new System.EventHandler(this.buttonCalculateLengthSDD_Click);
            // 
            // buttonCalculateWeightSDD
            // 
            this.buttonCalculateWeightSDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCalculateWeightSDD.Location = new System.Drawing.Point(198, 111);
            this.buttonCalculateWeightSDD.Name = "buttonCalculateWeightSDD";
            this.buttonCalculateWeightSDD.Size = new System.Drawing.Size(100, 50);
            this.buttonCalculateWeightSDD.TabIndex = 24;
            this.buttonCalculateWeightSDD.Text = "=";
            this.buttonCalculateWeightSDD.UseVisualStyleBackColor = true;
            this.buttonCalculateWeightSDD.Click += new System.EventHandler(this.buttonCalculateWeightSDD_Click);
            // 
            // ConversionFormSDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 674);
            this.Controls.Add(this.buttonCalculateWeightSDD);
            this.Controls.Add(this.buttonCalculateLengthSDD);
            this.Controls.Add(this.buttonCalculateVolumeSDD);
            this.Controls.Add(this.comboBoxChooseOutVolumeSDD);
            this.Controls.Add(this.comboBoxChooseInVolumeSDD);
            this.Controls.Add(this.comboBoxChooseOutLengthSDD);
            this.Controls.Add(this.comboBoxChooseInLengthSDD);
            this.Controls.Add(this.comboBoxChooseOutWeightSDD);
            this.Controls.Add(this.comboBoxChooseInWeightSDD);
            this.Controls.Add(this.textBoxOutputVolumeSDD);
            this.Controls.Add(this.textBoxInputVolumeSDD);
            this.Controls.Add(this.textBoxOutputLengthSDD);
            this.Controls.Add(this.textBoxInputLengthSDD);
            this.Controls.Add(this.textBoxOutputWeightSDD);
            this.Controls.Add(this.textBoxInputWeightSDD);
            this.Controls.Add(this.labelConversionVolumeSDD);
            this.Controls.Add(this.labelConversionLengthSDD);
            this.Controls.Add(this.labelConversionWeightSDD);
            this.Controls.Add(this.menuStripTypeOFCalcSDD);
            this.Name = "ConversionFormSDD";
            this.Text = "Перевод единиц измерений SSD";
            this.menuStripTypeOFCalcSDD.ResumeLayout(false);
            this.menuStripTypeOFCalcSDD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuStripTypeOFCalcSDD;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripMenuItemTypeSDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOrdinarySDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemArithmeticSDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConversionSDD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFitnessSDD;
        private System.Windows.Forms.ToolStripButton ToolStripMenuItemInfoSDD;
        private System.Windows.Forms.Label labelConversionWeightSDD;
        private System.Windows.Forms.Label labelConversionLengthSDD;
        private System.Windows.Forms.Label labelConversionVolumeSDD;
        private System.Windows.Forms.TextBox textBoxInputWeightSDD;
        private System.Windows.Forms.TextBox textBoxOutputWeightSDD;
        private System.Windows.Forms.TextBox textBoxInputLengthSDD;
        private System.Windows.Forms.TextBox textBoxOutputLengthSDD;
        private System.Windows.Forms.TextBox textBoxInputVolumeSDD;
        private System.Windows.Forms.TextBox textBoxOutputVolumeSDD;
        private System.Windows.Forms.ComboBox comboBoxChooseInWeightSDD;
        private System.Windows.Forms.ComboBox comboBoxChooseOutWeightSDD;
        private System.Windows.Forms.ComboBox comboBoxChooseOutLengthSDD;
        private System.Windows.Forms.ComboBox comboBoxChooseInLengthSDD;
        private System.Windows.Forms.ComboBox comboBoxChooseOutVolumeSDD;
        private System.Windows.Forms.ComboBox comboBoxChooseInVolumeSDD;
        private System.Windows.Forms.Button buttonCalculateLengthSDD;
        private System.Windows.Forms.Button buttonCalculateWeightSDD;
        private System.Windows.Forms.Button buttonCalculateVolumeSDD;
    }
}