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

        public void ViewGestureOptions(List<string> gestureOptions)
        {
            Console.WriteLine("Make your choice from the following options: ");

            for(int i = 0; i < gestureOptions.Count; i++)
            {
                Console.WriteLine(gestureOptions[i]);
            }
        }

        //choose gesture option override
        public abstract void ChooseGesture();
        

        

    }
}
