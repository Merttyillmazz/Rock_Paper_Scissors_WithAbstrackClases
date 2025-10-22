using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Player
    {
        public string Name { get; set; }
        public string Move { get; set; }

        public abstract void Makemove();
    }
}
