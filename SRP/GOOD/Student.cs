using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRP
{
    class Student : User
    {
        public bool IsGraduated()
        {
            bool isGraduated = false;

            // calcul de la moyenne de l'étudiant en fonction des notes de l'étudiant, 
            // application de regles métiers (notes éliminatoires, etc...
            return isGraduated;
        }

        public float CalculateAverage()
        {
            float avg = 0;

            // calcul en fonction des notes de l'étudiants, application de regles métiers (notes éliminatoires, etc...
            return avg;
        }
    }
}
