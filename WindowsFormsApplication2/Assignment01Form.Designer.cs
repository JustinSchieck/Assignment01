namespace WindowsFormsApplication2
{
    partial class Assignment01Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment01Form));
            this.EnglishOption = new System.Windows.Forms.RadioButton();
            this.FrenchOption = new System.Windows.Forms.RadioButton();
            this.GermanOption = new System.Windows.Forms.RadioButton();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeId = new System.Windows.Forms.TextBox();
            this.hoursWorked = new System.Windows.Forms.TextBox();
            this.TotalSales = new System.Windows.Forms.TextBox();
            this.SalesBonus = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Languagelbl = new System.Windows.Forms.Label();
            this.SpanishOption = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EnglishOption
            // 
            this.EnglishOption.AutoSize = true;
            this.EnglishOption.Location = new System.Drawing.Point(264, 39);
            this.EnglishOption.Name = "EnglishOption";
            this.EnglishOption.Size = new System.Drawing.Size(75, 21);
            this.EnglishOption.TabIndex = 0;
            this.EnglishOption.TabStop = true;
            this.EnglishOption.Text = "English";
            this.EnglishOption.UseVisualStyleBackColor = true;
            // 
            // FrenchOption
            // 
            this.FrenchOption.AutoSize = true;
            this.FrenchOption.Location = new System.Drawing.Point(264, 66);
            this.FrenchOption.Name = "FrenchOption";
            this.FrenchOption.Size = new System.Drawing.Size(83, 21);
            this.FrenchOption.TabIndex = 1;
            this.FrenchOption.TabStop = true;
            this.FrenchOption.Text = "Francais";
            this.FrenchOption.UseVisualStyleBackColor = true;
            // 
            // GermanOption
            // 
            this.GermanOption.AutoSize = true;
            this.GermanOption.Location = new System.Drawing.Point(264, 93);
            this.GermanOption.Name = "GermanOption";
            this.GermanOption.Size = new System.Drawing.Size(81, 21);
            this.GermanOption.TabIndex = 2;
            this.GermanOption.TabStop = true;
            this.GermanOption.Text = "Deutsch";
            this.GermanOption.UseVisualStyleBackColor = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(227, 210);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(219, 22);
            this.EmployeeName.TabIndex = 3;
            this.EmployeeName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Location = new System.Drawing.Point(227, 239);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(100, 22);
            this.EmployeeId.TabIndex = 4;
            // 
            // hoursWorked
            // 
            this.hoursWorked.Location = new System.Drawing.Point(227, 269);
            this.hoursWorked.Name = "hoursWorked";
            this.hoursWorked.Size = new System.Drawing.Size(100, 22);
            this.hoursWorked.TabIndex = 5;
            // 
            // TotalSales
            // 
            this.TotalSales.Location = new System.Drawing.Point(227, 302);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Size = new System.Drawing.Size(100, 22);
            this.TotalSales.TabIndex = 6;
            // 
            // SalesBonus
            // 
            this.SalesBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonus.Location = new System.Drawing.Point(227, 330);
            this.SalesBonus.Name = "SalesBonus";
            this.SalesBonus.Size = new System.Drawing.Size(100, 22);
            this.SalesBonus.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(60, 215);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(115, 17);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Employee Name:";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(84, 245);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(91, 17);
            this.IdLabel.TabIndex = 9;
            this.IdLabel.Text = "Employee ID:";
            this.IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(68, 274);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(103, 17);
            this.HoursLabel.TabIndex = 10;
            this.HoursLabel.Text = "Hours Worked:";
            this.HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(88, 305);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(83, 17);
            this.TotalSalesLabel.TabIndex = 11;
            this.TotalSalesLabel.Text = "Total Sales:";
            this.TotalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(80, 335);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(103, 17);
            this.SalesBonusLabel.TabIndex = 12;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            this.SalesBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(52, 394);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 30);
            this.CalculateBtn.TabIndex = 13;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(204, 394);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 30);
            this.PrintBtn.TabIndex = 14;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(362, 394);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 30);
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Languagelbl
            // 
            this.Languagelbl.AutoSize = true;
            this.Languagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Languagelbl.Location = new System.Drawing.Point(260, 9);
            this.Languagelbl.Name = "Languagelbl";
            this.Languagelbl.Size = new System.Drawing.Size(90, 20);
            this.Languagelbl.TabIndex = 17;
            this.Languagelbl.Text = "Language";
            // 
            // SpanishOption
            // 
            this.SpanishOption.AutoSize = true;
            this.SpanishOption.Location = new System.Drawing.Point(264, 121);
            this.SpanishOption.Name = "SpanishOption";
            this.SpanishOption.Size = new System.Drawing.Size(80, 21);
            this.SpanishOption.TabIndex = 18;
            this.SpanishOption.TabStop = true;
            this.SpanishOption.Text = "Espanol";
            this.SpanishOption.UseVisualStyleBackColor = true;
            // 
            // Assignment01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.SpanishOption);
            this.Controls.Add(this.Languagelbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SalesBonus);
            this.Controls.Add(this.TotalSales);
            this.Controls.Add(this.hoursWorked);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.GermanOption);
            this.Controls.Add(this.FrenchOption);
            this.Controls.Add(this.EnglishOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Assignment01Form";
            this.Text = "Sales Bonus Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EnglishOption;
        private System.Windows.Forms.RadioButton FrenchOption;
        private System.Windows.Forms.RadioButton GermanOption;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox EmployeeId;
        private System.Windows.Forms.TextBox hoursWorked;
        private System.Windows.Forms.TextBox TotalSales;
        private System.Windows.Forms.TextBox SalesBonus;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Languagelbl;
        private System.Windows.Forms.RadioButton SpanishOption;
    }
}

