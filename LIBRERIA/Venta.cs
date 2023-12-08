using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
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
    public partial class Venta : Form
    {
        Producto prod = new Producto();
        Ventass venta = new Ventass();

        public Venta()
        {
            InitializeComponent();
        }

        private void buttonBuscVenta_Click(object sender, EventArgs e)
        {
            List<Producto> res = prod.consultarPorTitulo($"Name LIKE '%{textBoxNombreVenta.Text}%'");
            if (res.Count > 0)
            {
                foreach (Producto prodResultado in res)
                {
                    dataGridLista.Rows.Add(new object[] { prodResultado.id, prodResultado.nombre, prodResultado.descripcion, prodResultado.precio, prodResultado.cantidad });
                    textBoxNombreVenta.Clear();
                }
            }
        }
        private void buttonAgregarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridLista.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridLista.SelectedRows;
                foreach (DataGridViewRow row in selectedRows)
                {
                    int index = dataGridVenta.Rows.Add();
                    dataGridVenta.Rows[index].Cells[0].Value = row.Cells[0].Value;
                    dataGridVenta.Rows[index].Cells[1].Value = row.Cells[1].Value;
                    dataGridVenta.Rows[index].Cells[2].Value = row.Cells[2].Value;
                    dataGridVenta.Rows[index].Cells[3].Value = row.Cells[3].Value;
                    dataGridVenta.Rows[index].Cells[4].Value = numericCantVentas.Value;
                    dataGridVenta.Refresh();
                }

                //meter en un for para sumar todos los renglones.
                double recibir = 0;
                for (int i = 0; i < dataGridVenta.Rows.Count - 1; i++)
                {
                    double total = Convert.ToDouble(dataGridVenta.Rows[i].Cells[3].Value.ToString()) * Convert.ToDouble(dataGridVenta.Rows[i].Cells[4].Value.ToString());
                    recibir += total;
                }
                textBoxTotalVenta.Text = recibir.ToString();
                double sub = recibir / 1.04;
                textBoxSubVenta.Text = sub.ToString("N2");
                double iva = recibir - sub;
                textBoxIVA.Text = iva.ToString("N2");
            }
            else
            {
                MessageBox.Show("Favor de seleccionar un producto");
            }
        }

        private void buttonPagarVenta_Click(object sender, EventArgs e)
        {
            List<ProductoAVender> productoAVenders = new List<ProductoAVender>();
            for (int i = 0; i < dataGridVenta.Rows.Count - 1; i++)
            {
                ProductoAVender prodVender = new ProductoAVender(int.Parse(dataGridVenta.Rows[i].Cells[0].Value.ToString()), int.Parse(dataGridVenta.Rows[i].Cells[4].Value.ToString()));
                productoAVenders.Add(prodVender);
            }
            double vent = venta.registrarVenta(1, double.Parse(textBoxTotalVenta.Text), double.Parse(textBoxEfectivoVenta.Text), productoAVenders);
            double feria = double.Parse(textBoxEfectivoVenta.Text) - double.Parse(textBoxTotalVenta.Text);
            if (feria < 0 | vent == -1)
            {
                MessageBox.Show("Error al registrar venta", Ventass.msgError);
            }
            else
            {
                MessageBox.Show("Venta Exitosa.", "Su cambio es $" + feria + ". Gracias, vuelva pronto :).");
                textBoxEfectivoVenta.Clear();
                textBoxSubVenta.Clear();
                textBoxTotalVenta.Clear();
                textBoxNombreVenta.Clear();
                numericCantVentas.ResetText();
                dataGridLista.Rows.Clear();
                dataGridVenta.Rows.Clear();
            }
        }

        private void buttonSalirVenta_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
