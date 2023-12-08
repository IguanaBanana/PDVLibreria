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

namespace LIBRERIA
{
    public partial class Editarcs : Form
    {
        Producto prod = new Producto();
        public Editarcs()
        {
            InitializeComponent();
        }

        private void buttonSeleccionarEditar_Click(object sender, EventArgs e)
        {
            List<Producto> res = prod.consultarPorTitulo($"Name LIKE '%{textBoxTituloEditarBuscar.Text}%'");
            if (res.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Producto prodResultado in res)
                {
                    dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.nombre, prodResultado.descripcion, prodResultado.precio, prodResultado.cantidad });
                    textBoxIDEditar.Clear();
                    textBoxTituloEditar.Clear();
                    textBoxDescEditar.Clear();
                    textBoxPrecioEditar.Clear();
                    textBoxCantidadEditar.Clear();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDEditar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTituloEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDescEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxCantidadEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxPrecioEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxIDEditar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTituloEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxDescEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxCantidadEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxPrecioEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void buttonEditarEditar_Click(object sender, EventArgs e)
        {
            presentacion valorPresentacion = new presentacion();
            //convertir de string a PResentacion
            //switch (comboBoxCategoriaEditar.SelectedItem.ToString())
            //{
            //    case "Terror":
            //        valorPresentacion = presentacion.Terror; break;
            //    case "Romance":
            //        valorPresentacion = presentacion.Romance; break;
            //    case "Fantasia":
            //        valorPresentacion = presentacion.Fantasia; break;
            //}
            bool resultado = prod.modificar(int.Parse(textBoxIDEditar.Text), textBoxTituloEditar.Text,textBoxDescEditar.Text, int.Parse(textBoxPrecioEditar.Text), int.Parse(textBoxCantidadEditar.Text));
            if (resultado == true)
                
            {
                MessageBox.Show("Guardado satisfactoriamente " + Producto.msgError);
                List<Producto> res = prod.consultarPorTitulo($"Name= '{textBoxTituloEditar.Text}'");
                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (Producto prodResultado in res)
                    {
                        dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.nombre, prodResultado.descripcion, prodResultado.precio, prodResultado.cantidad });
                        textBoxIDEditar.Clear();
                        textBoxTituloEditar.Clear();
                        textBoxDescEditar.Clear();
                        textBoxPrecioEditar.Clear();
                        textBoxCantidadEditar.Clear();
                    }
                }
            }
        }
    }
}
