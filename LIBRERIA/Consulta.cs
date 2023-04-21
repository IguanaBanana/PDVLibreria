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
    public partial class Consulta : Form
    {
        Producto prod = new Producto();
        public Consulta()
        {
            InitializeComponent();
            inicializarValoresDataGrid();
        }

        private void buttonBuscarConsulta_Click(object sender, EventArgs e)
        {
            List<Producto> res = prod.consultarPorTitulo($"Titulo LIKE '%{textBoxTituloConsulta.Text}%'");
            if (res.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Producto prodResultado in res)
                {
                    dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.titulo, prodResultado.issn, prodResultado.autor, prodResultado.presentacion, prodResultado.precio });
                    textBoxAutorConsulta.Clear();
                    textBoxTituloConsulta.Clear();
                }
            }
            else { MessageBox.Show("Titulo inexistente."); }
        }

        private void buttonBuscarxAutor_Click(object sender, EventArgs e)
        {
            List<Producto> res = prod.consultarPorAutor($"Autor LIKE '%{textBoxAutorConsulta.Text}%'");
            if (res.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Producto prodResultado in res)
                {
                    dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.titulo, prodResultado.issn, prodResultado.autor, prodResultado.presentacion, prodResultado.precio });
                    textBoxAutorConsulta.Clear();
                    textBoxTituloConsulta.Clear();
                }
            }
            else { MessageBox.Show("Autor inexistente."); }
        }
        private void inicializarValoresDataGrid()
        {
            List<Producto> res = prod.consultageneral("productos");
            if (res.Count > 0)
            {
                foreach (Producto prodResultado in res)
                {
                    int index = dataGridView1.Rows.Add();
                    dataGridView1.Rows[index].Cells[0].Value = prodResultado.id;
                    dataGridView1.Rows[index].Cells[1].Value = prodResultado.titulo;
                    dataGridView1.Rows[index].Cells[2].Value = prodResultado.issn;
                    dataGridView1.Rows[index].Cells[3].Value = prodResultado.autor;
                    dataGridView1.Rows[index].Cells[4].Value = prodResultado.presentacion;
                    dataGridView1.Rows[index].Cells[5].Value = prodResultado.precio;
                    dataGridView1.Refresh();
                }
            }
        }
    }
}

