using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Personne
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private int age;
        public Personne()
        {

        }
        public Personne(string nom)
        {
            this.nom = nom;
        }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public int Age { get => age; set => age = value; }
    }
}
