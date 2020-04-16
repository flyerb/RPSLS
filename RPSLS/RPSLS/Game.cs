using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //var (has a)
        public int pointsNeededtoWin;
        public List<string> gestureOptions;
        public Player Player1; //= new Human(); //declare as parent and instantiate the child 
        public Player Player2;

        //ctor


        public Game()
        {
            pointsNeededtoWin = 3;
            Player1 = new Human(); // because it will always be a human 

            gestureOptions = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        //methods (can do)

        public void RunGame()
        {
            DisplayRules();
            ChooseGameMode();
             // bbecause there are 2 instances of this class // have to pass in a list of gestures- which was declared as a variable above 
          
            while(Player1.score < pointsNeededtoWin && Player2.score < pointsNeededtoWin)
            {
                Player1.ViewGestureOptions(gestureOptions);
                Player1.ChooseGesture();
                Player2.ViewGestureOptions(gestureOptions);
                Player2.ChooseGesture();
                AssignPoint();
            }
            if(Player1.score == pointsNeededtoWin)
            {
                Console.WriteLine("Player One Won!");
            }
            else if (Player2.score == pointsNeededtoWin)
            {
                Console.WriteLine("Player Two Won!");
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock\n");
        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Would you like to play against a person or the computer? Please press 1 for person or 2 for computer.");
            string userinput = Console.ReadLine();

            if (userinput == "1")
            {
                Player2 = new Human();
            }
            else if (userinput == "2")
            {
                Player2 = new Computer();
            }
            else
            {
                Console.WriteLine("You did not input a valid option.");
                ChooseGameMode();
            }

        }
        public void AssignPoint()
        {
            if (Player1.chosenGesture == Player2.chosenGesture)
            {
                Console.WriteLine("It's a Tie!\n");

            }
            if ((Player1.chosenGesture == "0" && Player2.chosenGesture == "3") || (Player1.chosenGesture == "0" && Player2.chosenGesture == "2"))
            {
                Player1.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");

            }
            else if ((Player1.chosenGesture == "" && Player2.chosenGesture == "0") || (Player1.chosenGesture == "1" && Player2.chosenGesture == "4"))
            {
                Player1.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player1.chosenGesture == "2" && Player2.chosenGesture == "1") || (Player1.chosenGesture == "2" && Player2.chosenGesture == "3"))
            {
                Player1.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");

            }
            else if ((Player1.chosenGesture == "3" && Player2.chosenGesture == "4") || (Player1.chosenGesture == "3" && Player2.chosenGesture == "1"))
            {
                Player1.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player1.chosenGesture == "4" && Player2.chosenGesture == "4") || (Player1.chosenGesture == "2" && Player2.chosenGesture == "0"))
            {
                Player1.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player2.chosenGesture == "0" && Player1.chosenGesture == "3") || (Player2.chosenGesture == "0" && Player1.chosenGesture == "2"))
            {
                Player2.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player2.chosenGesture == "1" && Player1.chosenGesture == "0") || (Player2.chosenGesture == "1" && Player1.chosenGesture == "4"))
            {
                Player2.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player2.chosenGesture == "2" && Player1.chosenGesture == "1") || (Player2.chosenGesture == "2" && Player1.chosenGesture == "3"))
            {
                Player2.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player2.chosenGesture == "3" && Player1.chosenGesture == "4") || (Player2.chosenGesture == "3" && Player1.chosenGesture == "1"))
            {
                Player2.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
            else if ((Player2.chosenGesture == "4" && Player1.chosenGesture == "2") || (Player2.chosenGesture == "4" && Player1.chosenGesture == "0"))
            {
                Player2.score++;
                Console.WriteLine("Player One, your score is: " + Player1.score);
                Console.WriteLine("Player Two, your score is: " + Player2.score + "\n");
            }
        }

    }
}
        
    


