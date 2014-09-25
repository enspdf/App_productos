using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Productos.BD
{
    public class Productos
    {
        public int id_producto { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public int cantidad { get; set; }

        public Productos()
        {

        }

        public Productos(int pid_producto, String pnombre, String pdescripcion, int pcantidad)
        {
            this.id_producto = pid_producto;
            this.nombre = pnombre;
            this.descripcion = pdescripcion;
            this.cantidad = pcantidad;
        }
    }
}
