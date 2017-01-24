using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Assignment01Form : Form
    {
        private String _currentLanguage;

        public String CurrentLanguage
        {
            get { return this._currentLanguage; }
            set { this._currentLanguage = value;}
        }

        public Assignment01Form()
        {
            InitializeComponent();
            EnglishOption.Checked = true;
            this.CurrentLanguage = "English";
        }

        private void EnglishOption_Click(object sender, EventArgs e)
        {
            EnglishOption.Checked = true;
            this.CurrentLanguage = "English";
            changeLanguage();
        }

        private void FrenchOption_Click(object sender, EventArgs e)
        {
            EnglishOption.Checked = true;
            this.CurrentLanguage = "English";
            changeLanguage();
        }

        private void GermanOption_Click(object sender, EventArgs e)
        {
            EnglishOption.Checked = true;
            this.CurrentLanguage = "English";
            changeLanguage();
        }

        private void SpanishOption_Click(object sender, EventArgs e)
        {
            EnglishOption.Checked = true;
            this.CurrentLanguage = "English";
            changeLanguage();
        }

        private void changeLanguage()
        {
            switch (this.CurrentLanguage)
            {
                case "English":
                    NameLabel.Text = "Employee Name: ";
                    IdLabel.Text = "Employee ID: ";
                    HoursLabel.Text = "Hours Worked: ";
                    TotalSalesLabel.Text = "Total Sales: ";
                    SalesBonusLabel.Text = "Sales Bonus: ";


                    CalculateBtn.Text = "Calculate";
                    PrintBtn.Text = "Print";
                    ClearBtn.Text = "Clear";

                    Languagelabel.Text = "Language";
                    break;
            }
        }

        private void clearForm()
        {

            EmployeeNameTextBox.Text = "";
            EmployeeIdTextBox.Text = "";
            HoursWorkedTextBox.Text = "";
            TotalSalesTextBox.Text = "";
            SalesBonusTextBox.Text = "";
            this.Controls.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnglishOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrenchOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GermanOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SpanishOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            CalculateSalesBonus();
        }

        private void CalculateSalesBonus()
        {
            const double BonusPercentage = 0.02;
            const int MaxWorkHours = 160;
            double TotalHoursWorkedTextBox;
            double TotalMonthlySalesTextBox;
            double SalesBonus;
            double PercentageOfHoursWorked;
            double TotalBonus;

            try
            {
                TotalHoursWorkedTextBox = Convert.ToDouble(HoursWorkedTextBox.Text);
                PercentageOfHoursWorked = TotalHoursWorkedTextBox / MaxWorkHours;
                TotalMonthlySalesTextBox = Convert.ToDouble(TotalSalesTextBox.Text);
                TotalBonus = TotalMonthlySalesTextBox * BonusPercentage;
                SalesBonus = PercentageOfHoursWorked * TotalBonus;
                SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);

            }      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int HoursWorked;
                HoursWorked = Convert.ToInt32(HoursWorkedTextBox);

                if (HoursWorked > 160)
                {
                    MessageBox.Show("Hours cannot exceed 160");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data", "Input Error");
                Debug.WriteLine(exception.Message);

                HoursWorkedTextBox.Focus();
                HoursWorkedTextBox.SelectAll();
                ResetHoursWorkedTextBox();
            }
        }

        private void ResetHoursWorkedTextBox()
        {
            HoursWorkedTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            HoursWorkedTextBox.SelectAll();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void ResetText()
        {
            HoursWorkedTextBox.Focus();
            HoursWorkedTextBox.Text = "";
            HoursWorkedTextBox.SelectAll();

            EmployeeNameTextBox.Focus();
            EmployeeNameTextBox.Text = "";
            EmployeeNameTextBox.SelectAll();

            EmployeeIdTextBox.Focus();
            EmployeeIdTextBox.Text = "";
            EmployeeIdTextBox.SelectAll();

            SalesBonusTextBox.Focus();
            SalesBonusTextBox.Text = "";
            SalesBonusTextBox.SelectAll();
        }

        private void ResetHoursWorked()
        {
            HoursWorkedTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            HoursWorkedTextBox.SelectAll();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sending to Printer...");
        }

        private String PrintMessage()
        {
            throw new NotImplementedException();
        }
    }
}
