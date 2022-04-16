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
                var sql = "sp_proveedor_leer_general";

                var lstpaises = connection.Query<vista_proveedor>(sql, commandType:CommandType.StoredProcedure);
                
                foreach(var oElement in lstpaises)
                {
                    Console.WriteLine(oElement.proveedor_ruc);
                }
                MasterConnection.ClosedConnection();
            }
        }

    }
}
