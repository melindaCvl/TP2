using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.GOOD
{
    class Canari : Oiseau, IVolant
    {
        public Canari()
        {
        }

        public void Voler()
        {
            Console.WriteLine("Je suis un canari et je vole... :) !");
        }

        public override void Manger()
        {
            Console.WriteLine("Je suis un canari et je mange...");
        }
    }
}
