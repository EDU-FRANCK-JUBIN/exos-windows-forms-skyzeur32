using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Chanson
    {
        private string _nomArtiste;
        private string _titreChanson;

        public Chanson()
        {

        }

        public Chanson(string nomArtiste, string titreChanson)
        {
            NomArtiste = nomArtiste;
            TitreChanson = titreChanson;
        }

        public string NomArtiste { get => _nomArtiste; set => _nomArtiste = value; }
        public string TitreChanson { get => _titreChanson; set => _titreChanson = value; }
    }
}
