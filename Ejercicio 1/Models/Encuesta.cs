using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Encuesta
    {
        public bool contactable { get; private set; }
        public bool usabici { get; private set; }
        public bool usaauto { get; private set; }
        public bool transpubli { get; private set; }
        public string email { get; private set; }
        public double distancia { get; private set; }
        public Encuesta(bool bici, bool auto, bool publi, string email, double dist, bool contac)
        {
            contactable = contac;
            usabici = bici;
            usaauto = auto;
            transpubli = publi;
            this.email = email;
            distancia = dist;
        } 

    }
}
