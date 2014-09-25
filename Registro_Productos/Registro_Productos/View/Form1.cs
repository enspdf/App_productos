using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Productos.BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btningresar_Click(object sender, EventArgs e)
        {
            Productos Productos = new Productos();
            Productos.id_producto = Convert.ToInt32(txtid_producto.Text);
            Productos.nombre = txtnombre.Text;
            Productos.descripcion = txtdescripcion.Text;
            Productos.cantidad = Convert.ToInt32(txtcantidad.Text);

            int resultado = ProductosDA.Agregar(Productos);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se Puedieron Guardar los Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
