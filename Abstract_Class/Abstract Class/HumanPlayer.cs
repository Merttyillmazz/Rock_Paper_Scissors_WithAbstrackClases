using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class HumanPlayer:Player
    {   
        public HumanPlayer(string name)
        {
            Name = name;
        }
        public override void Makemove()
        {
            Console.WriteLine($"{Name},choose a move (rock,paper,scisors) ");
            Move = Console.ReadLine().ToLower();
        }
    }
}
