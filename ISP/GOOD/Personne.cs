using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.GOOD
{
    public class Personne : ISP.GOOD.IPersonne, IMailable, ISmsable
    {

        public DateTime DateDeNaissance { get; set; }

        public int Age
        {
            get
            {
                // calcul approximatif de l'age en fonction de la date de naissance
                return (int)(DateTime.Now.Subtract(DateDeNaissance).TotalDays / 365.25);
            }
        }

        public string Nom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Prenom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void EnvoyerMail()
        {
            throw new NotImplementedException();
        }

        public void EnvoyerSMS()
        {
            throw new NotImplementedException();
        }
    }
}
