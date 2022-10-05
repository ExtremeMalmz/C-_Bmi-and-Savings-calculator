//Eric Malmström

using BMIspace;
using SavingCalculatorSpace;
using System.DirectoryServices;

namespace Csharp_Ass3
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new BMICalculator();
        private SavingsCalculator savingsCalc = new SavingsCalculator();
        public MainForm()
        {
            //Constructor for MainForm
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            //initialize the GUI
            this.Text += "Super calculator by Eric Malmström";

            //Clear the text
            nameBox.Text = string.Empty;
            heightBox.Text = string.Empty;
            weightBox.Text = string.Empty;
            bmiOutputBox.Text = string.Empty;
            weightCategoryOutputBox.Text = string.Empty;

            //Default button is metric, so its automatically checked at the start
            radioButton2.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Accidently created this, if deleted it crashes program
        }

    

        private void label10_Click(object sender, EventArgs e)
        {
            //Accidently created this, if deleted it crashes 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When the user clicks the "calculate BMI" button this happens

            string unitType = this.bmiCalc.GetUnitType();

            //since there are two options to determine BMI (imperial metric) i found it fitting to have an IF here

            if(unitType == "Metric")
            {
                //try and catch for invalid attributes
                try 
                {
                    //setting the class attributes to the inputted values
                    this.bmiCalc.SetName(nameBox.Text);
                    this.bmiCalc.SetHeight(Convert.ToDouble(heightBox.Text));
                    this.bmiCalc.SetWeight(Convert.ToDouble(weightBox.Text));
                }
                //catches invalid type
                catch(FormatException)
                {
                    //we just set everything to zero
                    this.bmiCalc.SetName("Mr Error");
                    this.bmiCalc.SetHeight(0);
                    this.bmiCalc.SetWeight(0);
                }
                //sets the name in the result box to the one the user gave
                resultBox.Text = "Results for " + nameBox.Text;

                //calculates BMI 
                double bmi = this.bmiCalc.CalculateBMI();
                //uses BMI to determine what weightclass they should be in
                string weightClass = this.bmiCalc.FindWeightClass(bmi);
                //calculates normal weight 
                double normalWeight = Convert.ToInt16(this.bmiCalc.CalculateNormalWeight());


                //sets the bmi and weightclass and normal weight range to the windows form
                bmiOutputBox.Text = bmi.ToString();
                weightCategoryOutputBox.Text = weightClass;
                label12.Text = "Normal weight should be between " + normalWeight + " and " + (normalWeight + 18) + " kgs";
            }
            else if(unitType == "Imperial")
            {
                //try and catch
                try
                {
                    //feet and inches are converted into a metric height
                    double feet = Convert.ToDouble(heightBoxFeet.Text);
                    double inches = Convert.ToDouble(heightBoxInches.Text);
                    double height = this.bmiCalc.ConvertToMeters(feet, inches);

                    //pounds are also converted to metric :)
                    double pounds = Convert.ToDouble(weightBox.Text);
                    double weight = this.bmiCalc.ConvertToKilos(pounds);

                    this.bmiCalc.SetName(nameBox.Text);
                    this.bmiCalc.SetHeight(height);
                    this.bmiCalc.SetWeight(weight);
                }
                catch (FormatException)
                {
                    double height = 0;
                    double weight = 0;

                    this.bmiCalc.SetName(nameBox.Text);
                    this.bmiCalc.SetHeight(height);
                    this.bmiCalc.SetWeight(weight);
                }
                
                //calculates BMI 
                double bmi = this.bmiCalc.CalculateBMI();
                //uses BMI to determine what weightclass they should be in
                string weightClass = this.bmiCalc.FindWeightClass(bmi);
                //calculates normal weight 
                double normalWeight = this.bmiCalc.CalculateNormalWeight();
                normalWeight = Convert.ToInt16(this.bmiCalc.ConvertNormalWeightToPounds(normalWeight));


                //sets the bmi and weightclass and normal weight range to the windows form
                bmiOutputBox.Text = bmi.ToString();
                weightCategoryOutputBox.Text = weightClass;
                label12.Text = "Normal weight should be between " + normalWeight + " and " + (normalWeight + 41) + " lbs";

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //sets enum to imperial
            this.bmiCalc.SetEnumToImperial();

            //sets the labels to the imperial system
            heightLabel.Text = "Height (ft, and in)";
            weightLabel.Text = "Weight (lbs)";

            //hides the metric heightbox
            heightBox.Visible = false;
            //unhides the imperial height bxoes
            heightBoxFeet.Visible = true;
            heightBoxInches.Visible = true;

            //sets the metric box to zero 
            heightBox.Text = "0";
        }

     
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //sets enum to metric
            this.bmiCalc.SetEnumToMetric();

            //sets labels to the metric system
            heightLabel.Text = "Height (cm)";
            weightLabel.Text = "Weight (kg)";

            //sets "heightBox" to visible, its for metric values
            heightBox.Visible = true;
            //hides the imperial height boxes
            heightBoxFeet.Visible = false;
            heightBoxInches.Visible = false;

            //sets the imperial boxes to zero 
            heightBoxFeet.Text = "0";
            heightBoxInches.Text = "0";
        }

        private void calculateSavingsButton_Click(object sender, EventArgs e)
        {
            //method is executed when the user clicks on calculate savings
            //calculates the savings based on the period and monthly deposit

            try
            {
                //getting values from the boxes
                double monthlyDeposit = Convert.ToDouble(monthlyDepositBox.Text);
                double period = Convert.ToDouble(periodBox.Text);

                //put the new values into the overloaded constructor
                this.savingsCalc = new SavingsCalculator(monthlyDeposit, period);
            }
            //catching bad attributes
            catch (FormatException)
            {
                //setting values to zero so the program doesnt crash
                double monthlyDeposit = 0;
                double period = 0;

                //put the new values into the overloaded constructor
                this.savingsCalc = new SavingsCalculator(monthlyDeposit, period);
            }

            //calculating the amount paid in the amount of years provided
            double amountPaid = this.savingsCalc.CalculateAmountPaid(); //works
            //calculates the final balance
            double finalBalance = this.savingsCalc.CalculateFinalSavings();

            //sets results to whats in the box
            amountPaidBox.Text = amountPaid.ToString();
            finalBalanceBox.Text = finalBalance.ToString();
        }
    }
}