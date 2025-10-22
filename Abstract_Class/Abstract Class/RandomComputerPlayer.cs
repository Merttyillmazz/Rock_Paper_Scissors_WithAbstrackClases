using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class RandomComputerPlayer:ComputerPlayer
    {
        private static Random rand = new Random();
        private string[] moves = { "rock", "paper", "scissors" };

        public override void Makemove()
        {
            move = moves[rand.Next(moves.Length)];
        }
    }
}
