using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class GAme
    {
        private HumanPlayer human;
        private RandomComputerPlayer computerPlayer;
        private int playerscore = 0, compueterscore = 0, draw = 0;
        private List<string> history = new List<string>();
        
        public void start()
        {
            Console.WriteLine("enter your name ; ");
            human = new HumanPlayer(Console.ReadLine());
            computerPlayer = new RandomComputerPlayer();

            bool continueplaying = true;

            while (continueplaying)
            {
                human.Makemove();
                computerPlayer.Makemove();

                Console.WriteLine($"computer move is {computerPlayer.move}");
                string result = Determinewinner(human.Move, computerPlayer.move);
                history.Add($"{human.Move} vs {computerPlayer.move} -> {result}");
                Console.WriteLine($"{human.Name} = {playerscore}---computer = {compueterscore}----draw = {draw}");
                CheckContinueCondition(ref continueplaying);                    
            }
            showresult();
        }
        public string Determinewinner(string playermove,string computermove)
        {
            if (playermove == computermove)
            {
                draw++;
                return "its a draw";
            }
            if(playermove == "rock"&& computermove == "scissors"||
                playermove == "scissors" && computermove == "paper"||
                playermove == "paper"&& computermove == "rock")
            {
                playerscore++;
                return "player wins";
            }
            else
            {
                compueterscore++;
                return "computer wins";
            }
        }
        public void showresult()
        {
            Console.WriteLine($"----------------------------------------");
            Console.WriteLine("these are the results\n");
            foreach (var results in history){
                Console.WriteLine(results);
            }
            Console.WriteLine($"{human.Name}={playerscore}------computer = {compueterscore}--------draw = {draw}");
            string endresult;
            if(playerscore == compueterscore)
            {
                endresult = "result is a draw";
            }
            else if (playerscore > compueterscore)
            {
                endresult = $"congrulations {human.Name} you win";
            }
            else
            {
                endresult = $"unfortunately {human.Name} lost";
            }
            foreach (char letter in endresult)
            {
                Console.Write(letter);
                Thread.Sleep(25);
            }
            Console.WriteLine();
            string endofthegame = "END OF THE GAME";
            foreach (char letter in endofthegame)
            {
                Console.WriteLine(letter);
                Thread.Sleep(100);
            }
            

        }
        public static bool CheckContinueCondition(ref bool continuecondition)
        {
            Console.WriteLine("do you want to keep playing : y/n");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                continuecondition=true;
                return continuecondition;
            }
            else if(choice == "n")
            {
                continuecondition=false;
                return continuecondition;
            }
            else
            {
                Console.WriteLine("enter a valid value");
                CheckContinueCondition(ref continuecondition);

            }
            return continuecondition;

        }


    }
}
