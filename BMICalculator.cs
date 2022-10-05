namespace BMIspace
{
    class BMICalculator
    {
        private string name = "No one";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        public BMICalculator()
        {
            //Constructor class
            this.name = "Jerome Fakeson";
            this.height = 501;
            this.weight = 501.2;
        }
        public string GetUnitType()
        {
            //Getter for unittypes
            //Console.WriteLine(unit.ToString());

            //made it tostring since I found it easier to use in a string format
            return unit.ToString();
        }
        public void SetName(string name)
        {
            //setter for name
            this.name = name;
        }

        public void SetHeight(double height)
        {
            //setter for height
            this.height = height;
        }

        public void SetWeight(double weight)
        {
            //setter for weight
            this.weight = weight;
        }

        public void SetEnumToImperial()
        {
            //setter for enum type Imperial
            this.unit = UnitTypes.Imperial;
        }

        public void SetEnumToMetric()
        {
            //sets the enum to metric
            this.unit = UnitTypes.Metric;
        }

        public double CalculateBMI()
        {
            //Calculates BMI using given formula
            //Console.WriteLine("Weight: " + this.weight + " Height: " + this.height);
            return Math.Round((this.weight / this.height / this.height) * 10000,2);
        }

        public string FindWeightClass(double weight)
        {
            //Calculates the weight class based on the weight of the user returns a string

            //Console.WriteLine(this.height);
            //Console.WriteLine(this.weight);

            if (weight < 18.5)
            {
                return "Underweight";
            }
                else if(weight >= 18.5 && weight <= 24.9)           
                {
                    return "Normal Weight";
                }
                    else if(weight >= 25.0 && weight <= 29.9)
                    {
                        return "Overweight (Pre-obesity)";
                    }
                        else if(weight >= 30.0 && weight <= 34.9)
                        {
                            return "Overweight (Obesity class 1)";
                        }
                            else if(weight >= 35.0 && weight <= 39.0)
                            {
                                return "Overweight (Obesity class 2)";
                            }
                                else if(weight >= 40.0)
                                {
                                    return "Overweight (Obesity class 3)";
                                }
            else
            {
                return "Unable to calculate BMI";
            }
        }

        public double CalculateNormalWeight()
        {
            //calculates the normal weight of the user and returns a double

            //Console.WriteLine("CALCULATING NORMAL WEIGHT");
            //Calculates normal weight based on the height and weight provided

            double userBMI = CalculateBMI();

            //assigning class variables to local variables as we will need to change these 
            double userWeight = this.weight;
            //Console.WriteLine("ORIGINAL User weight:" + userWeight);

            if (userBMI > 18.5)
            {
                while(userBMI >= 18.5)
                {
                    //minus one weight till it gets the desired bmi (under 18.50)
                    userWeight = userWeight - 0.1;
                    userBMI = (userWeight / this.height / this.height) * 10000;
                    //Console.WriteLine("User weight (minused):" + userWeight);
                }
                //Console.WriteLine("NORMAL WEIGHT (minused) IS: " + userWeight);
                return userWeight;
            }
            else if(userBMI <= 18.5)
            {
                //Console.WriteLine("BMI UNDER 25");
                while(userBMI <= 18.5)
                {
                    //plus one till we get the BMI to 18.5
                    userWeight = userWeight + 1;
                    userBMI = (userWeight / this.height / this.height) * 10000;
                    //Console.WriteLine("User weight (plussed):" + userWeight);
                }
                //for some reason the results return an accurate number when you minus it by one, so its hard coded to subtract one after its done calculating
                userWeight = userWeight - 1;

                //Console.WriteLine("NORMAL WEIGHT (plussed) IS: " + userWeight);
                return userWeight;
            }
            return 0;
        }


        public double ConvertToMeters(double feet,double inches)
        {
            //Converts the feets and inches (input) into meters
            double totalHeight = 0;

            //calculating feet into meters
            for(int i = 0; i < feet; i++) 
            {
                //one foot is 0.3048 meters
                totalHeight = totalHeight + 0.3048;
            }

            //Console.WriteLine("Feet: " + totalHeight);

            //calculating inches into meters
            while (inches != 0)
            {
                if(inches >= 1)
                {
                    totalHeight = totalHeight + 0.0254;
                    inches = inches - 1;
                    //Console.WriteLine(inches);
                }
                else
                {
                    totalHeight = totalHeight + (0.0254 * inches) ;
                    inches = 0;
                    //Console.WriteLine(totalHeight);
                }
            }
            //Console.WriteLine("Feet+inch: " + totalHeight);

            //Console.WriteLine(Math.Round(totalHeight, 1)*100);
            return totalHeight *100;
        }

        public double ConvertToKilos(double pounds)
        {
            //Converts pounds to kilos
            return pounds * 0.45359237;
        }

        public double ConvertNormalWeightToPounds(double normalWeight)
        {
            //gets the normal weight in kilos and converts it to pounds
            return normalWeight * 2.2;
        }

        public void say_hello()
        {
            //this is a debug class for when you want a response from console
            Console.WriteLine("hello");
        }
    }
}