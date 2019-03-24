using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRP.GOOD
{
    abstract class User
    {
        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid UserId { get; set; }

        public void Inser()
        { }

        public void Update()
        { }

    }
}