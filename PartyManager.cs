using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManager_Space
{
    class PartyManager
    {
        private double? costPerPerson;
        private double? feePerPerson;
        private string[] guestList;
        public PartyManager(string maxNumOfGuests)
        {
            //Constructor for PartyManager. Takes input maxNumberOfGuests and creates a string array with the int value of maxNumberOfGuests 
            this.guestList = new string[Convert.ToInt16(maxNumOfGuests)];

            //Console.WriteLine(maxNumOfGuests);
        }


        public void Set_CostPerPerson(string costPerPerson)
        {
            this.costPerPerson = Convert.ToDouble(costPerPerson);
        }

        public void Set_FeePerPerson(string feePerPerson)
        {
            this.feePerPerson = Convert.ToDouble(feePerPerson);
        }

        private int CalculateNonNullArrayLength()
        {
            int nonNullElementCounter = 0;
            for(int i = 0;i < guestList.Length; i++)
            {
                if (guestList[i] != null)
                {
                    if(guestList[i] != String.Empty)
                    {
                        nonNullElementCounter++;
                        //Console.WriteLine("not null element detected!");
                    }
                }
            }

            //Console.WriteLine(nonNullElementCounter);

            return nonNullElementCounter;
        }

        public string NmrOfGuests()
        {
            return Convert.ToString(CalculateNonNullArrayLength());
        }

        public string TotalCost()
        {
            CalculateNonNullArrayLength();
            return Convert.ToString(Convert.ToDouble(CalculateNonNullArrayLength() * costPerPerson));
        }

        public string TotalFees()
        {
            return Convert.ToString(Convert.ToDouble(CalculateNonNullArrayLength() * feePerPerson));
        }

        public string TotalDeficitOrSurplus()
        {
            return Convert.ToString(Convert.ToDouble(TotalFees()) - Convert.ToDouble(TotalCost()));
        }

        public string ConvertNamesToStyle(string firstName, string lastName)
        {
            //Converts the first and last name into arrayPos LASTNAME, firstname

            AppendToArray(lastName.ToUpper() + ", " + firstName);

            return CalculateNonNullArrayLength() + " " + lastName.ToUpper() + ", " + firstName;
        }

        private void AppendToArray(string text)
        {
            //sets the guestList where a null value is - needs an outofbounds catcher
            guestList[CalculateNonNullArrayLength()] = text;


            //prints entire list
            /*
            for(int i = 0; i < guestList.Length; i++)
            {
                Console.WriteLine(guestList[i]);
            }
            */ 
        }

        public string FixFirstName(string fullName)
        {
            try
            {
                return fullName.Substring(fullName.IndexOf(',') + 1).Trim();
            }
            
            catch (ArgumentOutOfRangeException)
            {
                return "Unable to find person123";
            }
        }

        public string FixLastName(string fullName)
        {
            try
            {
                return fullName.Substring(0, fullName.IndexOf(',') + 1).Trim().Remove(0, 2).Replace(",", "");
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Unable to find person1";
            }
        }

        public void DeleteAGuest(string guestName,int selectedIndex)
        {
            guestName = guestName.Remove(0, 2).Trim();
            //Console.WriteLine("Name is: " + guestName);

            guestList[selectedIndex] = String.Empty;

            MoveElementsOneStepToLeft(selectedIndex);
        }

        private void MoveElementsOneStepToLeft(int deletedIndex)
        {
            //moves the array up after deleting
            for(int i = deletedIndex+1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = String.Empty;
            }
        }
        

        //this was an earlier version, please ignore
        /*
        public void DeleteAGuest(int deleteAtThisIndex)
                {
            
                    //Make sure this is not -1
                    //Console.WriteLine(deleteAtThisIndex);
                    if(deleteAtThisIndex != -1)
                    {
                        //delete at index
                        //Console.WriteLine(deleteAtThisIndex);

                        guestList[deleteAtThisIndex] = String.Empty;

                        //MoveElementsOneStepToLeft(deleteAtThisIndex);
                    }
                }
        public int FindIndex(string stringWeWantToDelete)
        {
            //removing extra stuff so we can find it in the real guest list
            stringWeWantToDelete = stringWeWantToDelete.Remove(0, 2);
            stringWeWantToDelete = stringWeWantToDelete.Replace("\n", "").Replace("\r", "");

            Console.WriteLine("Delete :" + stringWeWantToDelete);
            //Console.WriteLine("Found at:" + guestList[1]);
            int index = 0;
            for(int i = 0; i < guestList.Length; i++)
            {
                index++;
                if (guestList[i] == stringWeWantToDelete)
                {
                    Console.WriteLine("FOUND IT @ " + index);
                    return index;
                }
            }

            //idk about this
            return 0;
        }
        */
    }
}


