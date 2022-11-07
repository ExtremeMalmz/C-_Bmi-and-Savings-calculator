using PartyManager_Space;
using System;
using System.Windows.Forms;

namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        private PartyManager? partymanager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            //clears list of items
            guestListBox.Items.Clear();
            inviteGuestBox.Enabled = false;
        }

        private void createListButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have created a list with" + maxNmrOfGuestsBox.Text + " guests!");

            //Allowing user to access the add guest buttons
            guestListBox.Items.Clear();
            inviteGuestBox.Enabled = true;

            //sets attributes of the partymanager
            partymanager = new PartyManager(maxNmrOfGuestsBox.Text);
            partymanager.Set_CostPerPerson(costPerPersonBox.Text);
            partymanager.Set_FeePerPerson(feePerPersonBox.Text);

            CalculateCosts();
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            int numOfGuestsInvited = Convert.ToInt16(partymanager.NmrOfGuests());
            //Console.WriteLine(numOfGuestsInvited);
            
            if(numOfGuestsInvited != Convert.ToInt16(maxNmrOfGuestsBox.Text))
            {
                //when you add a guest
                guestListBox.Items.Add(partymanager.ConvertNamesToStyle(firstNameBox.Text, lastNameBox.Text) + "\r\n");

                //you have to calculate costs again
                CalculateCosts();
            }
            else
            {
                MessageBox.Show("List is full, name has not been added!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = guestListBox.SelectedIndex;
            //delete the string in the array
            partymanager.DeleteAGuest(guestListBox.Text, index);
            
            //Delete the item from the listBox
            
            guestListBox.Items.RemoveAt(index);

            //Update the listbox
            UpdateGuestList(index);

            //calculate costs after deletion
            CalculateCosts();

            //this was an earlier solution
            /*
            //this the string we want to delete
            string stringWeWantToDelete = guestListBox.GetItemText(guestListBox.SelectedItem);
            int deletionIndex = partymanager.FindIndex(stringWeWantToDelete);

            //delete guest from the partymanager list
            partymanager.DeleteAGuest(deletionIndex);

            //Console.WriteLine(guestListBox.SelectedIndex.ToString());
            guestListBox.Items.RemoveAt(deletionIndex);

            //update the guestList so that the index values are correct
            //guestListBox.SelectedIndex always returns -1. use a method in partymanager to find the TRUE INDEX
            //int trueIndex = partymanager.FindIndex(guestListBox);

          
            UpdateGuestList(deletionIndex);

            //Calculate new costs
            CalculateCosts();
            */
        }

        
        private void UpdateGuestList(int deletedIndex)
        {
            //Updates the guest list after deletion

            //should be deletedIndex
            for(int i = deletedIndex; i < guestListBox.Items.Count; i++)
            {
                //Setting string text to whats at the index of the guestListBox
                string text = guestListBox.GetItemText(guestListBox.Items[i].ToString());

                //Minus the first value in the string (index) by 1 so we get an accurate index
                int updatedIndex = Convert.ToInt16(Convert.ToString(text[0])) - 1;
                //remove the old index
                text = text.Remove(0, 1);
                //get the updated index into the text
                text = updatedIndex.ToString() + text;

                //add the new and shiny index back into the list
                guestListBox.Items[i] = text;
                
            }
        }
        
        private void CalculateCosts()
        {
            //this should be moved to add guest
            nmrOfGuestsBox.Text = partymanager.NmrOfGuests();
            totalCostBox.Text = partymanager.TotalCost();
            totalFeesBox.Text = partymanager.TotalFees();
            surplusDeficitBox.Text = partymanager.TotalDeficitOrSurplus();
        }

        private void guestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the user clicks on the guest lists it will put that guest in the ADD GUEST bar
            if(guestListBox.SelectedIndex > 0)
            {
                firstNameBox.Text = partymanager.FixFirstName(guestListBox.Text);
                lastNameBox.Text = partymanager.FixLastName(guestListBox.Text);
            }
            else
            {

            }
        }
    }
}