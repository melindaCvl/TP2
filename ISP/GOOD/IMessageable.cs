using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.GOOD
{
    public interface IMessageable : IJoigneable
    {
        int Pseudo { get; set; }

        void EnvoyerMessage();
    }
}