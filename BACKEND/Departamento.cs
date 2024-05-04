using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_intercomunicacion_de_la_red_vial_de_la_república.BACKEND
{

    public class Departamento
    {
        public int id;
        public string Nombre { get; set; }
        public string NombreCabecera { get; set; }
        public double DistanciaDesdeCapital { get; set; }
        public int Poblacion { get; set; }
        public int CantidadMunicipios { get; set; }

        public Departamento(string nombreCabecera, double distanciaDesdeCapital, int poblacion, int cantidadMunicipios, string nombre, int iddepartamento)
        {
            NombreCabecera = nombreCabecera;
            DistanciaDesdeCapital = distanciaDesdeCapital;
            Poblacion = poblacion;
            CantidadMunicipios = cantidadMunicipios;
            Nombre = nombre;
            id = iddepartamento;
        }
    }


}
