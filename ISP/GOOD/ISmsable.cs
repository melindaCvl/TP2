using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.GOOD
{
    public interface ISmsable : IJoigneable
    {
        void EnvoyerSMS();
    }
}