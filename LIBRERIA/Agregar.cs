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
            switch (comboBoxCategoriaAgregar.SelectedItem.ToString())
            {
                case "Terror":
                    valorPresentacion = presentacion.Terror; break;
                case "Romance":
                    valorPresentacion = presentacion.Romance; break;
                case "Fantasia":
                    valorPresentacion = presentacion.Fantasia; break;
            }
            bool resultado = prod.crear(textBoxTituloAgregar.Text, textBoxISSNAgregar.Text, textBoxAutorAgregar.Text, double.Parse(textBoxPrecioAgregar.Text), valorPresentacion);
            if (resultado == true)
            {
                MessageBox.Show("Guardado satisfactoriamente " + Producto.msgError);
                List<Producto> res = prod.consultarPorTitulo($"Titulo= '{textBoxTituloAgregar.Text}'");
                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (Producto prodResultado in res)
                    {
                        dataGridView1.Rows.Add(new object[] { prodResultado.id, prodResultado.titulo, prodResultado.issn, prodResultado.autor, prodResultado.presentacion, prodResultado.precio });
                        textBoxTituloAgregar.Clear();
                        textBoxAutorAgregar.Clear();
                        textBoxPrecioAgregar.Clear();
                        textBoxISSNAgregar.Clear();
                        comboBoxCategoriaAgregar.ResetText();
                    }
                }
            }
        }
    }
}


