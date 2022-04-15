using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FerreteríaPuntoVenta.ConnectionDB;
using FerreteríaPuntoVenta.Model;

namespace FerreteríaPuntoVenta.Controller
{
    class MasterController
    {
        public void listPais()
        {
            MasterConnection.OpenConnection();
            using (var connection = MasterConnection.s_connect)
            {
                var sql = "SP_PAIS_LISTAR";
                var lstpaises = connection.Query<MPais>(sql, commandType:CommandType.StoredProcedure);
                
                foreach(var oElement in lstpaises)
                {
                    Console.WriteLine(oElement.nombre_pais);
                }
                MasterConnection.ClosedConnection();
            }
        }

    }
}
