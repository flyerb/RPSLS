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
            int computerChoice = rnd.Next(0, 5);
            Console.WriteLine(computerChoice);
        }

    }
}
