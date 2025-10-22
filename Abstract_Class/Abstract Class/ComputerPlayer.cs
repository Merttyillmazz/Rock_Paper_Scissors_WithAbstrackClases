using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class ComputerPlayer
    {
        public string move { get; set; }

        public abstract void Makemove();
    }
}
