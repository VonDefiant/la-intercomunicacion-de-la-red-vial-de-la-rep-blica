using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace la_intercomunicacion_de_la_red_vial_de_la_república.BACKEND
{
    public class BaseDatosSQLite
    {
        private SQLiteConnection conexion;

        public BaseDatosSQLite(string rutaBaseDatos)
        {
            conexion = new SQLiteConnection("Data Source=" + rutaBaseDatos);
        }

        public void AbrirConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Closed)
            {
                conexion.Close();
            }
        }

        public void CrearTablaDepartamentos()
        {
            string query = @"CREATE TABLE IF NOT EXISTS Departamentos (
                            NombreCabecera TEXT,
                            DistanciaDesdeCapital REAL,
                            Poblacion INTEGER,
                            CantidadMunicipios INTEGER
                        )";

            EjecutarQuery(query);
        }

        public void InsertarDepartamento(Departamento departamento)
        {
            string query = @"INSERT INTO Departamentos (NombreCabecera, DistanciaDesdeCapital, Poblacion, CantidadMunicipios)
                        VALUES (@NombreCabecera, @DistanciaDesdeCapital, @Poblacion, @CantidadMunicipios)";

            SQLiteCommand comando = new SQLiteCommand(query, conexion);
            comando.Parameters.AddWithValue("@NombreCabecera", departamento.NombreCabecera);
            comando.Parameters.AddWithValue("@DistanciaDesdeCapital", departamento.DistanciaDesdeCapital);
            comando.Parameters.AddWithValue("@Poblacion", departamento.Poblacion);
            comando.Parameters.AddWithValue("@CantidadMunicipios", departamento.CantidadMunicipios);

            comando.ExecuteNonQuery();
        }

        private void EjecutarQuery(string query)
        {
            AbrirConexion();
            SQLiteCommand comando = new SQLiteCommand(query, conexion);
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}
