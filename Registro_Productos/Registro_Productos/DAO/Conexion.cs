using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Registro_Productos.BD
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion(){
            SqlConnection Conn = new SqlConnection("Data source=SEBASTIAN;Initial Catalog=productos; User Id=enspdf; Password=123");
            Conn.Open();

            return Conn;
        }
    }
}
