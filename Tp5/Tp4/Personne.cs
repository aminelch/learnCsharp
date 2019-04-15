using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5
{

    class Personne
    {
        List<Personne> table = new List<Personne>(); 

        private string cin = null ;
        private string nom = null;
        private string prenom = null;
        private string ville = null;
        private string tel = null;
        private int age=0;


        public string CIN
        {
            get { return cin; }
            set { nom = value; }

        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }

        }

        public string Ville
        {
            get { return ville; }
            set { ville = value; }

        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }

        }

        public int Age
        {
            get { return age; }
            set { age = value; }

        }

    }
}
