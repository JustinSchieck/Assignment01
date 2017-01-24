using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    /// <summary>
    /// 	App name = Mail Order Form
    /// 	Author's name = Justin Schieck
    /// 	App	CreationDate = January 24,2017
    /// 	App description = Calculates the Sales bonus from a set amount of hours for a certain 
    /// </summary>

    public partial class MailForm : Form
    {

        //Variables
        private String _currentLanguage;


        public String CurrentLanguage
        {
            get { return this._currentLanguage; }
            set { this._currentLanguage = value;}
        }
        
        //Sets English as Default
        public MailForm()
        {
            InitializeComponent();
            EnglishOption.Checked = true;
            this.CurrentLanguage = "English";
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


        //Language Code for multiple languages including english, french, german and spanish
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        //English
        private void EnglishOption_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Employee Name: ";
            IdLabel.Text = "Employee ID: ";
            HoursLabel.Text = "Hours Worked: ";
            TotalSalesLabel.Text = "Total Sales: ";
            SalesBonusLabel.Text = "Sales Bonus: ";


            CalculateBtn.Text = "Calculate";
            PrintBtn.Text = "Print";
            ClearBtn.Text = "Clear";

            Languagelabel.Text = "Language";
        }

        //French
        private void FrenchOption_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Nom de l'employé: ";
            IdLabel.Text = "ID employé: ";
            HoursLabel.Text = "Heures travaillées: ";
            TotalSalesLabel.Text = "Ventes totales: ";
            SalesBonusLabel.Text = "Bonus de vente: ";


            CalculateBtn.Text = "Calculer";
            PrintBtn.Text = "Impression";
            ClearBtn.Text = "Clair";

            Languagelabel.Text = "La langue";
        }

        //German
        private void GermanOption_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Mitarbeitername: ";
            IdLabel.Text = "Angestellten ID: ";
            HoursLabel.Text = "Arbeitsstunden: ";
            TotalSalesLabel.Text = "Gesamtumsatz: ";
            SalesBonusLabel.Text = "Verkaufsbonus: ";


            CalculateBtn.Text = "Berechnen";
            PrintBtn.Text = "Drucken";
            ClearBtn.Text = "Klar";

            Languagelabel.Text = "Sprache";
        }

        //Spanish
        private void SpanishOption_CheckedChanged(object sender, EventArgs e)
        {
            NameLabel.Text = "Nombre de empleado: ";
            IdLabel.Text = "ID de empleado: ";
            HoursLabel.Text = "Horas trabajadas: ";
            TotalSalesLabel.Text = "Ventas totales: ";
            SalesBonusLabel.Text = "Bono de ventas: ";


            CalculateBtn.Text = "Calcular";
            PrintBtn.Text = "Impresión";
            ClearBtn.Text = "Claro";

            Languagelabel.Text = "Idioma";
        }


        //Calculates the bonus
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


            //Checks that hours are between a limited amount
            try
            {

                double HoursWorked;
                HoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);

                if (HoursWorked > 160 || HoursWorked <= 0)
                {
                    MessageBox.Show("Hours must be betweeen 1 and 160");
                }


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
          
        }

        //resets the appropriate text boxes
        private void ResetHoursWorkedTextBox()
        {
            HoursWorkedTextBox.Focus();
            HoursWorkedTextBox.Text = "0";
            HoursWorkedTextBox.SelectAll();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
            HoursWorkedTextBox.Text = "";
            EmployeeNameTextBox.Text = "";
            EmployeeIdTextBox.Text = "";
            SalesBonusTextBox.Text = "";
            HoursWorkedTextBox.Text = "";
            
        }

        //Print button 
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
