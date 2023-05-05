using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk1._0
{
    internal class DeskQuote
    {
        // Attributes.
        /* This Attribute stores the current
           Desk object to be saved to a file by
           the DeskQuote class. */
        public Desk _desk;

        public string _customerName;
        public int _baseDeskPrice = 200;
        public int _drawerRate = 50;
        public int _totalPrice;
        // Added _rushType to hold the information for which
        // array to pull from.
        public string _rushType;

        /* These arrays will store the price information for the
           Rush orders. They will be set up as follows, 
           
           exampleArray[0] = Price while the surface area of the desk is less than 1000.
           exampleArray[1] = Price while the surface area of the desk is between 1000 and 2000.
           exampleArray[2] = Price while the surface area of the desk is above 2000.
           
           NOTE: The arrays will gain their values through this class's constructor.
        */
        public int[] _threeDayRush = new int[3];
        public int[] _fiveDayRush = new int[3];
        public int[] _sevenDayRush = new int[3];

        // Constructors.
        public DeskQuote(Desk currDesk, string customerName, string rushType) 
        {
            // Set up the arrays.
            _threeDayRush[0] = 60;
            _threeDayRush[1] = 70;
            _threeDayRush[2] = 80;

            _fiveDayRush[0] = 40;
            _fiveDayRush[1] = 50;
            _fiveDayRush[2] = 60;

            _sevenDayRush[0] = 30;
            _sevenDayRush[1] = 35;
            _sevenDayRush[2] = 40;

            // Set the Desk object container.
            _desk = currDesk;

            // Set the _customerName.
            _customerName = customerName;

            // Set the _rushType.
            _rushType = rushType;

            // All the other information for this class should be
            // contained in the _desk object.
        }

        // Methods.

        /* This method runs the calculating part of the class. This will call
           methods within this class to calculate the total, save the desk info to a file,
           and display the total on the DisplayQuote form. 
        */
        public void RunDeskQuote() 
        {
            // Code will go in here one day...
        }

        /* This method's job is to compute the total so the RunDeskQuote function can display it.
           This is done by setting the attribute _totalPrice.
        */
        public void ComputeTotal() 
        {
            // Code will end up here... hopefully...
        }

        /* You may need to add a save file function and load file function later on...
           which might require a few new attributes to hold loaded objects, and saved ones.
        */
    }
}
