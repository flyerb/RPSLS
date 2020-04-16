using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public int score;
        public string chosenGesture;

        // chosing a gesture is something than can do and something they have

        public void ViewGestureOptions(List<string> nmnhjh)
        {
            Console.WriteLine("Please choose a number from the following options: \n");

            for(int i = 0; i < nmnhjh.Count; i++)
            {
                Console.WriteLine(i + ")" + nmnhjh[i]);
            }
        
         }

        //choose gesture option override
        public abstract void ChooseGesture();

    }
}
