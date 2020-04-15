using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Run_Game
    {
        //var (has a)
        public int pointsNeededtoWin;
        public List<string> gestureOptions;
        public Player Player1; //= new Human(); //declare as parent and instantiate as child 
        public Player Player2;

        //ctor


        public Run_Game()
        {
            pointsNeededtoWin = 3;
            Player1 = new Human(); // because it will always be a human 

            gestureOptions = new List<string>() {"Rock", "Paper", "Sizssors", "Lizard", "Spock" }; 
        }

        //methods (can do)

        public void Game()
        {
            DisplayRules();
            ChooseGameMode();
            Player1.ViewGestureOptions(gestureOptions); // bbecause there are 2 insta ces of this class // have to pass in a list of estures- which was declared as a variable above and 
            //player1.CooseGesture
            //player2.viewgestureoptions
            //player2. CooseGesture
        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Would you like to play against a person or the computer? Please press 1 for person or 2 for computer.");
            string userinput = Console.ReadLine();

            if(userinput  == "1")
            {
                Player2 = new Human();
            }
            else if(userinput == "2")
            {
                Player2 = new Computer();
            }
            else
            {
                Console.WriteLine("You did not input a valid option. Please press 1 for person or 2 for computer.");
            }

        }

    }
}
