using System;
namespace ISP.GOOD
{
    public interface IPersonne
    {
        int Age { get; }
        DateTime DateDeNaissance { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
    }
}
