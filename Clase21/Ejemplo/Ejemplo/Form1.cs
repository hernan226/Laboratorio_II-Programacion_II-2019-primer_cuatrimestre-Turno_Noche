using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //propiedades del proyecto, (cadena de conexiom) y para acceder al dato
            //Properties.Settings.Default.SqlString

            string sqlString = Properties.Settings.Default.SqlString;

            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(sqlString);

            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;// viene por defecto asi
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText =
                "SELECT Nombre FROM Provincias";
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<string> aux = new List<string>();
            while (sqlDataReader.Read())
            {
                 aux.Add(sqlDataReader["Nombre"].ToString());
            }
            sqlConnection.Close();
            /*  crear constructor provincias
             *  con tostring que muestr nombre

            */
        }
    }
}
