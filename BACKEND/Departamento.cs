using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_intercomunicacion_de_la_red_vial_de_la_república.BACKEND
{

    public class Departamento
    {
        public string NombreCabecera { get; set; }
        public double DistanciaDesdeCapital { get; set; }
        public int Poblacion { get; set; }
        public int CantidadMunicipios { get; set; }
        public List<string> LugaresTuristicos { get; set; }

        public Departamento(string nombreCabecera, double distanciaDesdeCapital, int poblacion, int cantidadMunicipios, List<string> lugaresTuristicos)
        {
            NombreCabecera = nombreCabecera;
            DistanciaDesdeCapital = distanciaDesdeCapital;
            Poblacion = poblacion;
            CantidadMunicipios = cantidadMunicipios;
            LugaresTuristicos = lugaresTuristicos;
        }
    }

}
