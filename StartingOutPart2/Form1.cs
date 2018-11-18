using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartingOutPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            decimal food_Charge = decimal.Parse(foodCharge.Text);

           decimal tipValue =  (15/ food_Charge) * 100;
            tip.Text = tipValue.ToString();

            decimal taxValue = (7 / food_Charge) * 100;
            tax.Text = taxValue.ToString();


            total.Text = (tipValue + taxValue + food_Charge).ToString();


        }

        private void calculateDistance_Click(object sender, EventArgs e)
        {
            int speedNum = int.Parse(speed.Text);
            int timeNum = int.Parse(time.Text);

            distance.Text = (speedNum * timeNum).ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void calculateAverage_Click(object sender, EventArgs e)
        {
            try
            {
                const double HIGH_SCORE = 95.0;
                double test1, test2, test3, average;

                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                average = (test1 + test2 + test3) / 3.0;

                averageLabel.Text = average.ToString("n1");

                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Great JOB MAN!");
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";

            averageLabel.Text = "";

            //reset focus 
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BASE_HOURS = 40m;
                const decimal OVERTIME_HOURLY_PAY = 1.5m;

                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay; // pay not including overtime
                decimal overTimeHours;
                decimal overTimePay;
                decimal grossPay;

                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursWorked > BASE_HOURS)
                {
                    overTimeHours = hoursWorked - BASE_HOURS;
                    overTimePay = OVERTIME_HOURLY_PAY * overTimeHours;
                    basePay = BASE_HOURS * hourlyPayRate;
                    grossPay = basePay + overTimePay;

                }
                else
                {
                    grossPay = hourlyPayRate * hoursWorked;
                }
                grossPayLabel.Text = grossPay.ToString("c");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ClearPayRoll_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {

         
            const decimal QUALIFIED_LOAN = 40000m;
            const int MIN_YEARS = 2;

            decimal salary;
            int years;

            salary = decimal.Parse(salaryTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                if (salary >= QUALIFIED_LOAN)
                {
                    if (years >= MIN_YEARS)
                    {

                        decisionLabel.Text = "Congrdautions you get loan";
                    }
                    else
                    {
                        decisionLabel.Text = "Enough money but not enough year in current job";
                    }


                }
                else
                {
                    decisionLabel.Text = "No luck, no loan";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void determineGradeButton_Click(object sender, EventArgs e)
        {
            try
            {


                int score;

                score = int.Parse(testScoreTextBox.Text);

                if (score < 60)
                {
                    gradeLabel.Text = "You Got an F";
                }
                else
                {
                    if (score < 70)
                    {
                        gradeLabel.Text = "You Got an D";
                    }
                    else
                    {
                        if (score < 80)
                        {
                            gradeLabel.Text = "You Got an C";
                        }
                        else
                        {
                            if (score < 90)
                            {
                                gradeLabel.Text = "You Got an B";
                            }
                            else
                                gradeLabel.Text = "You Got an A";
                        }
                    }
                }
             
             }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
