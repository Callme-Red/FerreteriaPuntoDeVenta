using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteríaPuntoVenta.ConnectionDB
{
    class MasterConnection
    {
        public static string s_connectionString = @"Data source=DESKTOP-JQOH4UU; Initial Catalog=prueba; Integrated Security=True ";
        public static SqlConnection s_connect = new SqlConnection(s_connectionString);

        //Metodos internos para abrir y cerrar la conexion con la base de datos
        public static void OpenConnection()
        {
            if(s_connect.State == ConnectionState.Closed)
            {
                try
                {
                    s_connect.Open();
                    Console.WriteLine("Conexion abierta");
                }
                catch (SqlException ex)
                {

                    Console.WriteLine("Error en la conexion. " + ex);
                }
            }
        }

        public static void ClosedConnection()
        {
            if(s_connect.State == ConnectionState.Open)
            {
                s_connect.Close();
                Console.WriteLine("Conexion cerrada");
            }
        }

        public static String StringConnection()
        {
            return s_connectionString;
        }
    }
}
