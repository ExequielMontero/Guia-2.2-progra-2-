using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class ProcesoEncuesta
    {
        public int cantcontactables { get; private set; }
        public double porbicicleta { get; private set; }
        public double porauto { get; private set; }
        public double portranspub { get; private set; }

        ArrayList encuestas = new ArrayList();
        ArrayList contactables = new ArrayList();

        public void RegistrarEncuesta(Encuesta encuesta, bool puedesercontactado)
        {
            encuestas.Add(encuesta);
            if(puedesercontactado == true)
            {
                cantcontactables++;
            }
        }

        public Encuesta VerContactables(int idx)
        {
            return (Encuesta)contactables[idx];
        }

        public void OrdenarEncuestables()
        { Encuesta actual;
            Encuesta aca;
            Encuesta aya;
            for(int i=0; i<encuestas.Count; i++)
            {
                actual = (Encuesta)encuestas[i];
                if (actual.contactable == true)
                {
                    contactables.Add(encuestas[i]);
                }
            }
            if (contactables.Count > 0)
            {
                for(int i=0; i < contactables.Count-1;i++)
                {
                    aca = (Encuesta)contactables[i];
                    for(int j=i+1; j < contactables.Count;j++)
                    {
                        aya = (Encuesta)contactables[j];
                        if (aca.distancia > aya.distancia)
                        {
                            Encuesta aux = aya;
                            contactables[j] = contactables[i];
                            contactables[i] = aux;
                        }
                    }
                }
            }
        }

    }
}
