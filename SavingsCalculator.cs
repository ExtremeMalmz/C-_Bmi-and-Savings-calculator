using System.Runtime.CompilerServices;

namespace SavingCalculatorSpace
{
    class SavingsCalculator
    {
        private double monthlyDeposit;
        private const double interestRate = 0.10;
        private double period;

        public SavingsCalculator()
        {
            //default constructor
            this.monthlyDeposit = 123;
            this.period = 123;
        }

        public SavingsCalculator(double monthlyDeposit,double period)
        {
            //overloaded constructor
            this.monthlyDeposit = monthlyDeposit;    
            this.period = period;
            //Console.WriteLine("Monthly deposit: " + this.monthlyDeposit + " Period: " + this.period);
        }

        public double CalculateAmountPaid()
        {
            //multiplies the period (years) by 12 to get the amount of months, it then multiplies that by the monthly deposit giving the amount put in during the months
            //Console.WriteLine((this.period * 12) * this.monthlyDeposit);
            return (this.period * 12) * this.monthlyDeposit;
        }

        public double CalculateFinalSavings()
        {
            //period is years which multiplied with 12 gives us the total number of months
            double numOfMonths = this.period * 12;
            //the users future savings
            double futureBalance = 0;
            //the interest the user gains from their savings
            double interestEarned;

            //loop through the number of months and add the interest to the future balance
            for(int i = 0; i < numOfMonths; i++)
            {
                //interest éarned per month
                interestEarned = (interestRate/12) * futureBalance;
                //Console.WriteLine(this.interestRate + " * " + futureBalance + " = " + interestEarned);
                futureBalance += interestEarned + this.monthlyDeposit;
                //Console.WriteLine("Future balance -> " + interestEarned + " " + this.monthlyDeposit + " = " + futureBalance);
            }

            //Console.WriteLine(Math.Round(futureBalance,2));
            //round it to make it prettier
            return Math.Round(futureBalance, 2);
        }
    }
}