using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace la_intercomunicacion_de_la_red_vial_de_la_república
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            Cargardepartamentosencombox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdepartamento.SelectedIndex >= 0)
            {
                string departamentoseleccionado = cbdepartamento.SelectedItem.ToString();
                // Hacer algo con el departamento seleccionado
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un departamento válido.");
            }
        }

        private void gpsgo_Click(object sender, EventArgs e)
        {
            try
            {
                string departamento = cbdepartamento.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cargardepartamentosencombox()
        {
            try
            {
                string connectionString = "Data Source=BACKEND/EXACTUS.db;Version=3;";
                string selectQuery = "SELECT NOMBRE FROM DEPARTAMENTOS";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbdepartamento.Items.Add(reader["NOMBRE"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los departamentos: " + ex.Message);
            }
        }
    }
}
