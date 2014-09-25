using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Registro_Productos.BD
{
    public class ProductosDA
    {
        public static int Agregar(Productos pProductos)
        {
            int retorno = 0;
            using (SqlConnection Conn = Conexion.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into producto (id_producto, nombre, descripcion, cantidad) values ('{0}','{1}','{2}','{3}')",
                    pProductos.id_producto, pProductos.nombre, pProductos.descripcion, pProductos.cantidad), Conn);
                retorno = Comando.ExecuteNonQuery();

            }
            return retorno;
        }
    }
}
