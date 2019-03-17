using ISP.GOOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.GOOD
{
    public class AmiFacebook : IPersonne, IMessageable
    {
        public int Age => throw new NotImplementedException();

        public DateTime DateDeNaissance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Prenom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Pseudo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void EnvoyerMessage()
        {
            throw new NotImplementedException();
        }
    }
}