using la_intercomunicacion_de_la_red_vial_de_la_república.BACKEND;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace la_intercomunicacion_de_la_red_vial_de_la_república
{
    public partial class INICIO : Form
    {
        string DBFILE = "Data Source = C://Users//fg144//OneDrive//Documentos//GitHub//la-intercomunicacion-de-la-red-vial-de-la-republica//BACKEND//EXACTUS.db; Version = 3; ";
        string selectedDepartamento;


        public INICIO()
        {
            InitializeComponent();
            CargarDepartamentosencombobox();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartamento = comboBox1.SelectedItem.ToString();
            string departamentoID = ObtenerIDDepartamento(selectedDepartamento);
            string cabeceraDepartamento = ObtenerCabeceraDepartamento(selectedDepartamento);
            string distanciaDepartamento = ObtenerDISTANCIADepartamento(selectedDepartamento);
            string poblacionDepartamento = ObtenerpoblacionDepartamento(selectedDepartamento);
            string tmunicipioDepartamento = ObtenertmunicipioDepartamento(selectedDepartamento);

            CABECERALABEL.Text = cabeceraDepartamento;
            distancialabel.Text = distanciaDepartamento;
            NOMUNILABEL.Text = tmunicipioDepartamento;
            POBLALABEL.Text = poblacionDepartamento;

            cargarloslugaresturisticos(departamentoID);
        }

        private void lugarescercanosview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void POBLALABEL_Click(object sender, EventArgs e)
        {

        }
        private void CABECERALABEL_Click(object sender, EventArgs e)
        {

        }

        private void distancialabel_Click(object sender, EventArgs e)
        {

        }

        private void NOMUNILABEL_Click(object sender, EventArgs e)
        {

        }

        private void CargarDepartamentosencombobox()
        {
            try
            {

                string connectionString = DBFILE;
                string selectQuery = "SELECT Nombre FROM Departamentos";
                string departamenteID = $"SELECT Nombre FROM LugaresTuristicos WHERE DepartamentoId = (SELECT Id FROM Departamentos WHERE Nombre = '{selectedDepartamento}')";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar al cargar los departamanetos : " + ex.Message);
            }
        }

        private string ObtenerIDDepartamento(string departamento)
        {
            string departamentoID = "";
            try
            {
                string connectionString = DBFILE;
                string selectQuery = $"SELECT Id FROM Departamentos WHERE Nombre = '{departamento}'";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        departamentoID = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del departamento: " + ex.Message);
            }
            return departamentoID;
        }
        private void cargarloslugaresturisticos(string departamentoID)
        {
            try
            {
                string connectionString = DBFILE;
                string selectQuery = $"SELECT Nombre FROM LugaresTuristicos WHERE DepartamentoId = {departamentoID}";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);
                        lugaresview.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los lugares turísticos: " + ex.Message);
            }
        }
        private string ObtenerCabeceraDepartamento(string departamento)
        {
            string cabeceraDepartamento = "";
            try
            {
                string connectionString = DBFILE;
                string selectQuery = $"SELECT Cabecera FROM Departamentos WHERE Nombre = '{departamento}'";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        cabeceraDepartamento = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la cabecera del departamento: " + ex.Message);
            }
            return cabeceraDepartamento;
        }
        private string ObtenerDISTANCIADepartamento(string departamento)
        {
            string distanciaDepartamento = "";
            try
            {
                string connectionString = DBFILE;
                string selectQuery = $"SELECT DistanciaCapital || ' KM' AS Distancia FROM Departamentos WHERE Nombre = '{departamento}'";


                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        distanciaDepartamento = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la distancia del departamento: " + ex.Message);
            }
            return distanciaDepartamento;
        }
        private string ObtenerpoblacionDepartamento(string departamento)
        {
            string poblacionDepartamento = "";
            try
            {
                string connectionString = DBFILE;
                string selectQuery = $"SELECT poblacion FROM Departamentos WHERE Nombre = '{departamento}'";


                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        poblacionDepartamento = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la poblacion del departamento: " + ex.Message);
            }
            return poblacionDepartamento;
        }
        private string ObtenertmunicipioDepartamento(string departamento)
        {
            string tmunicipioDepartamento = "";
            try
            {
                string connectionString = DBFILE;
                string selectQuery = $"SELECT NumeroMunicipios FROM Departamentos WHERE Nombre = '{departamento}'";


                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        tmunicipioDepartamento = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la poblacion del departamento: " + ex.Message);
            }
            return tmunicipioDepartamento;
        }
    }
}
