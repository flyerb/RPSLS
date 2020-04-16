using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Computer: Player
    {
        public Computer()
        {
         //score: 0;
        }

        //methods
        public override void ChooseGesture()
        {
            Random rnd = new Random();
            chosenGesture = rnd.Next(0, 5).ToString();
            Console.WriteLine("Computer chooses " + chosenGesture + "\n");
        }

    }
}
