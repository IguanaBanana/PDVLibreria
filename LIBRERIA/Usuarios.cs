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
    public partial class Usuarios : Form
    {
        UsuariosMiddle usu = new UsuariosMiddle();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            bool resultado = usu.crearUsuarios(textBoxNombreUsuario.Text, textBoxCorreoUsuario.Text, textBoxPassUsuario.Text);
            if (resultado == true)
            {

                MessageBox.Show("Guardado satisfactoriamente " + Producto.msgError);
                List<UsuariosMiddle> res = usu.consultarUsuarios($"Nombre = '{textBoxNombreUsuario.Text}'");

                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (UsuariosMiddle usu in res)
                    {
                        dataGridView1.Rows.Add(new object[] { usu.id, usu.nombre, usu.correo, usu.password });
                        textBoxIDUsuario.Clear();
                        textBoxNombreUsuario.Clear();
                        textBoxCorreoUsuario.Clear();
                        textBoxPassUsuario.Clear();

                    }
                }

            }
            else
            {
                MessageBox.Show("ERROR AL GUARDAR " + Producto.msgError);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNombreUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCorreoUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxPassUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            bool resultado = usu.modificarUsuarios(int.Parse(textBoxIDUsuario.Text), textBoxNombreUsuario.Text, textBoxCorreoUsuario.Text, textBoxPassUsuario.Text);
            if (resultado == true)
            {
                MessageBox.Show("Guardado satisfactoriamente " + Producto.msgError);
                List<UsuariosMiddle> res = usu.consultarUsuarios($"Nombre =  '{textBoxNombreUsuario.Text}' AND Password =  '{textBoxPassUsuario.Text}'");
                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (UsuariosMiddle usu in res)
                    {
                        dataGridView1.Rows.Add(new object[] { usu.id, usu.nombre, usu.correo, usu.password });
                        textBoxIDUsuario.Clear();
                        textBoxNombreUsuario.Clear();
                        textBoxCorreoUsuario.Clear();
                        textBoxPassUsuario.Clear();
                    }
                }
            }
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            bool resultado = usu.borrarUsuario(int.Parse(textBoxIDUsuario.Text));
            if (resultado == false)
            {
                MessageBox.Show("Eliminado con exito" + Producto.msgError);
                dataGridView1.Rows.Clear();
                textBoxIDUsuario.Clear();
                textBoxNombreUsuario.Clear();
                textBoxCorreoUsuario.Clear();
                textBoxPassUsuario.Clear();
            }
        }

        private void buttonBuscarUsu_Click(object sender, EventArgs e)
        {
            List<UsuariosMiddle> res = usu.consultarUsuarios($"Nombre =  '{textBoxNombreUsuario.Text}'");
            if (res.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (UsuariosMiddle usu in res)
                {
                    dataGridView1.Rows.Add(new object[] { usu.id, usu.nombre, usu.correo, usu.password });
                    textBoxIDUsuario.Clear();
                    textBoxNombreUsuario.Clear();
                    textBoxCorreoUsuario.Clear();
                    textBoxPassUsuario.Clear();
                }
            }
        }
    }
}

