using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace pruebaCapas001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=3030;database=Tutorial;";
            string query = "SELECT * FROM Clientes";  // Tu consulta en SQL 
                                                      // Prepara la conexión 

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            // Abre la base de datos 
            databaseConnection.Open();
            // Ejecuta las consultas  y carga el resultado en un sql DATAREADER (reader) 
            reader = commandDatabase.ExecuteReader();
            DataTable tabla = new DataTable("Clientes");
            //carga el SQLdatareader en una data table 
            tabla.Load(reader);
            DG1.DataSource = tabla;// cargo el data grid    con la tabla 
                                   // Cerrar la conexión 
            databaseConnection.Close();
        }

       
private void btnCargar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            DataTable tabla = new DataTable("Clientes");
            DataRow fila;//creo una variable donde guardo el registro de la tabla
        }
    }
}
