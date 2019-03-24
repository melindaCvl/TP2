using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.GOOD
{
    class Autruche : Oiseau
    {
        public Autruche()
        {
        }

        public override void Manger()
        {
            Console.WriteLine("Je suis une autruche et je mange...");
        }
    }
}
