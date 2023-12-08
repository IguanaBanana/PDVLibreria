using Middle_Abarrotes_PDV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;


namespace LIBRERIA
{
    public partial class Agregar : Form
    {
        Producto prod = new Producto();
        public Agregar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarAgregar_Click(object sender, EventArgs e)
        {
            presentacion valorPresentacion = new presentacion();
            //convertir de string a PResentacion
            //switch (comboBoxCategoriaAgregar.SelectedItem.ToString())
            //{
            //    case "Terror":
            //        valorPresentacion = presentacion.Terror; break;
            //    case "Romance":
            //        valorPresentacion = presentacion.Romance; break;
            //    case "Fantasia":
            //        valorPresentacion = presentacion.Fantasia; break;
            //}
            bool resultado = prod.crear(int.Parse(textBoxIdAgregar.Text), textBoxNombreAgregar.Text, textBoxDescripcion.Text, double.Parse(textBoxPrecioAgregar.Text), int.Parse(textBoxCantidadAgregar.Text));
            if (resultado == true)
            {
                MessageBox.Show("Guardado satisfactoriamente " + Producto.msgError);
                List<Producto> res = prod.consultarPorTitulo($"Name= '{textBoxIdAgregar.Text}'");
                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (Producto prodResultado in res)
                    {
                        dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.nombre, prodResultado.descripcion, prodResultado.precio, prodResultado.cantidad });
                        textBoxIdAgregar.Clear();
                        textBoxNombreAgregar.Clear();
                        textBoxPrecioAgregar.Clear();
                        textBoxCantidadAgregar.Clear();
                        textBoxDescripcion.Clear();
                    }
                }
            }
        }
    }
}


