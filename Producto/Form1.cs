using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto
{
    public partial class Form1 : Form
    {
        int posicion;
        public Form1()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtprecio.Clear();
            Txtdescripcion.Clear();
            txtcaducidad.Clear();
            txtcantidad.Clear();
            txtId.Clear();
            

           
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            String  descripcion, nombre, id,caducidad,unidadmedida,cantidad,precio;
            int cantidadd, precioo;

            nombre = txtNombre.Text;
            if (nombre == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con el nombre.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nombre is int)
            {
                MessageBox.Show($"Error, el nombre:{txtNombre.Text} no tiene el formato correcto.",
                           "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (nombre is decimal)
            {
                MessageBox.Show($"Error, el nombre:{txtNombre.Text} no tiene el formato correcto.",
                      "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







            precio = txtprecio.Text;

            descripcion = Txtdescripcion.Text;
            if (descripcion == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con el nombre.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = txtId.Text;

            if (id == "")
            {
                MessageBox.Show("Debe llenar la caja de texto con el nombre.",
                                "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                caducidad = txtcaducidad.Text;
            cantidad =txtcantidad.Text;
            limpiar();
           
            tbldatos.Rows.Add(id,nombre, descripcion, precio,cantidad,caducidad);

        }

        private void tbldatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           posicion = tbldatos.CurrentRow.Index;
            txtId.Text = tbldatos[1, posicion].Value.ToString();
            txtNombre.Text = tbldatos[2, posicion].Value.ToString();
           Txtdescripcion.Text = tbldatos[3, posicion].Value.ToString();
            txtprecio.Text = tbldatos[4, posicion].Value.ToString();
            txtcantidad.Text= tbldatos[5, posicion].Value.ToString();
            txtcaducidad.Text= tbldatos[6, posicion].Value.ToString();
         
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            String precio, descripcion, producto, id, cantidad, caducidad, unidadmedida;
            precio = txtprecio.Text;
            descripcion = Txtdescripcion.Text;
            producto = txtNombre.Text;
            id = txtId.Text;
            cantidad = txtcantidad.Text;
            caducidad = txtcaducidad.Text;
           
            tbldatos[1, posicion].Value = txtId.Text;
             tbldatos[2, posicion].Value =txtNombre.Text;
             tbldatos[3, posicion].Value= Txtdescripcion.Text;
           tbldatos[4, posicion].Value=txtprecio.Text;
           tbldatos[5, posicion].Value = txtcantidad;
           tbldatos[6, posicion].Value = txtcaducidad.Text;
          
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            tbldatos.Rows.RemoveAt(posicion);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
