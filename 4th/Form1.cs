using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//##############################################################################################
//Author: Mitchell Tracy
//Due Date: 9/26/2013
//App Describtion: This App allows the user to put there name, id, hours, total sales and how much bonus they will get.
namespace WindowsFormsApplication2
{
    public partial class SharpMailOrder : Form
    {
        // Declare the constant
        const decimal SALES_BONUS = 0.02m;
        const int TOTAL_HOURS = 160;
        private int Hoursworked = 0;

        public SharpMailOrder()
        {
            InitializeComponent();
            
        }
        // makes my images load in on the form load
        private void Form1_Load(object sender, EventArgs e)
        {
            MitchImage.Image = Properties.Resources.MitchLogo;
        }//end

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Changes the labels to English
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeName.Text = "Employee's Name";
            EmployeeID.Text = "Employee ID";
            Hours.Text = "Hours Worked";
            Sales.Text = "Total Sales";
            Bonus.Text = "Sales Bonus";
        }//end radio

      
        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           
        
        }    

        private void EmployeeName_Click(object sender, EventArgs e)
        {

        }


        private void Print_Click_1(object sender, EventArgs e)
        {
            // Print the form
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void EmployeeName_Click_1(object sender, EventArgs e)
        {
           
        }
        //Changes the labels to French
        private void French_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeName.Text = "Enquête de nom";
            EmployeeID.Text = "L'enquête ID";
            Hours.Text = "Heures Travaillées";
            Sales.Text = "Le total des ventes";
            Bonus.Text = "Bonus de ventes";
        }//end french

       
        //This button Clears all text fields
        private void Clear_Click_1(object sender, EventArgs e)
        {
            //clears fields
            EmpNameTextBox.Clear();
            EmpIDTextBox.Clear();
            HoursTextBox.Clear();
            SalesTextBox.Clear();
            BonusTextBox.Clear();
        }//end the clear

        private void Calculate_Click_1(object sender, EventArgs e)
        {
            {
                // Calculate the price and discount.
                decimal HoursWorkedDecimal;
                decimal TotalSalesDecimal;
                decimal HoursDecimal;
                decimal SalesDecimal;
                decimal TotalBonusDecimal;

                try
                {
                    // Convert input values to numeric variables.
                    HoursWorkedDecimal = decimal.Parse(HoursTextBox.Text);
                    TotalSalesDecimal = decimal.Parse(SalesTextBox.Text);

                    // Calculate values.
                    HoursDecimal = HoursWorkedDecimal / TOTAL_HOURS;
                    SalesDecimal = TotalSalesDecimal * SALES_BONUS;
                    TotalBonusDecimal = HoursDecimal * SalesDecimal;

                    // Format and display answers.
                    BonusTextBox.Text = TotalBonusDecimal.ToString("C");
                }
                catch (Exception TheException)
                {
                    MessageBox.Show(TheException.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {    //some exception message
            try
            {
                Hoursworked = int.Parse(HoursTextBox.Text);
            }
            catch (Exception theException)
            {
                MessageBox.Show(theException.Message);
            }//end exception
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Languages_Enter(object sender, EventArgs e)
        {

        }

       }
}
