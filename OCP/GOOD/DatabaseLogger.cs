using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.GOOD
{
    class DatabaseLogger : ILogger
    {
        public DatabaseLogger(String URLDatabase)
        {
            //Construc DatabaseLogger with database url
        }

        public void Write(string message)
        {
            // Write in database log
        }
    }
}
