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
        }

        private void buttonBuscarConsulta_Click(object sender, EventArgs e)
        {
            List<Producto> res = prod.consultarPorTitulo($"Titulo= '{textBoxTituloConsulta.Text}'");
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
            List<Producto> res = prod.consultarPorAutor($"Autor= '{textBoxAutorConsulta.Text}'");
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> res = prod.consultageneral("productos");
            if (res.Count > 0)
            {
                foreach (Producto prodResultado in res)
                {
                    dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.titulo, prodResultado.issn, prodResultado.autor, prodResultado.presentacion, prodResultado.precio });
                }
            }
        }
    }
}
