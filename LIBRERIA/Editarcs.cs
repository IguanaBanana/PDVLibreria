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
            List<Producto> res = prod.consultarPorTitulo($"Titulo= '{textBoxTituloEditarBuscar.Text}'");
            if (res.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Producto prodResultado in res)
                {
                    dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.titulo, prodResultado.issn, prodResultado.autor, prodResultado.presentacion, prodResultado.precio });
                    textBoxIDEditar.Clear();
                    textBoxTituloEditar.Clear();
                    textBoxISSNEditar.Clear();
                    textBoxAutorEditar.Clear();
                    textBoxPrecioEditar.Clear();
                    comboBoxCategoriaEditar.ResetText();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDEditar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTituloEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxISSNEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAutorEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxCategoriaEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPrecioEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxIDEditar.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxTituloEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxISSNEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxAutorEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxCategoriaEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxPrecioEditar.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }

        private void buttonEditarEditar_Click(object sender, EventArgs e)
        {
            Presentacion valorPresentacion = new Presentacion();
            //convertir de string a PResentacion
            switch (comboBoxCategoriaEditar.SelectedItem.ToString())
            {
                case "Terror":
                    valorPresentacion = Presentacion.Terror; break;
                case "Romance":
                    valorPresentacion = Presentacion.Romance; break;
                case "Fantasia":
                    valorPresentacion = Presentacion.Fantasia; break;
            }
            bool resultado = prod.modificar(int.Parse(textBoxIDEditar.Text), textBoxTituloEditar.Text, textBoxISSNEditar.Text, textBoxAutorEditar.Text, valorPresentacion, double.Parse(textBoxPrecioEditar.Text));
            if (resultado == true)
            {
                MessageBox.Show("Guardado satisfactoriamente " + Producto.msgError);
                List<Producto> res = prod.consultarPorTitulo($"Titulo= '{textBoxTituloEditar.Text}'");
                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (Producto prodResultado in res)
                    {
                        dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.titulo, prodResultado.issn, prodResultado.autor, prodResultado.presentacion, prodResultado.precio });
                        textBoxIDEditar.Clear();
                        textBoxTituloEditar.Clear();
                        textBoxISSNEditar.Clear();
                        textBoxAutorEditar.Clear();
                        textBoxPrecioEditar.Clear();
                        comboBoxCategoriaEditar.ResetText();
                    }
                }
            }
        }
    }
}
