using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.GOOD
{
    class Oiseau
    {
        public Oiseau()
        {
        }

        public virtual void Manger()
        {
            Console.WriteLine("Je suis un oiseau et je mange...");
        }
    }
}
