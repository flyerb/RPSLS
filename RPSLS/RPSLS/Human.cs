using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        //variables 

        //ctor

        public override void ChooseGesture()
        {
            string chosenGesture = Console.ReadLine();
            if (chosenGesture == "0" || chosenGesture == "1" || chosenGesture == "2" || chosenGesture == "3" || chosenGesture == "4")
            {
                Console.WriteLine("Great Choice!");
            }
            else
            {
                Console.WriteLine("You did not enter a valid option.");
                ChooseGesture();
            }
        }
    }
}


