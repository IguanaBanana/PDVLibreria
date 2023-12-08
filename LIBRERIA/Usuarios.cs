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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            textBoxPassUsusario.Enabled = true;
            textBoxNombreUsuario.Enabled = true;
            textBoxCorreoUsuario.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxTelefono.Enabled = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDUsuario.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNombreUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCorreoUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxPassUsusario.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            bool resultado = usu.modificarUsuarios(textBoxIDUsuario.Text, textBoxNombreUsuario.Text, textBoxCorreoUsuario.Text, textBoxTelefono.Text, textBoxDireccion.Text, textBoxPassUsusario.Text);
            if (resultado == true)
            {
                MessageBox.Show("Guardado satisfactoriamente ");
                List<UsuariosMiddle> res = usu.consultarUsuarios($"Nombre =  '{textBoxNombreUsuario.Text}' AND Password =  '{textBoxPassUsusario.Text}'");
                if (res.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    foreach (UsuariosMiddle usu in res)
                    {
                        dataGridView1.Rows.Add(new object[] { usu.id, usu.nombre, usu.correo, usu.telefono, usu.direccion, usu.password });
                        textBoxIDUsuario.Clear();
                        textBoxNombreUsuario.Clear();
                        textBoxCorreoUsuario.Clear();
                        textBoxDireccion.Clear();
                        textBoxTelefono.Clear();
                        textBoxPassUsusario.Clear();
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
                textBoxDireccion.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar.");
            }
        }

        private void buttonBuscarUsu_Click(object sender, EventArgs e)
        {
            textBoxNombreUsuario.Enabled = true;
            textBoxPassUsusario.Enabled = false;
            textBoxCorreoUsuario.Enabled = false;
            textBoxDireccion.Enabled = false;
            textBoxTelefono.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBoxNombreUsuario.Text))
                {
                    List<UsuariosMiddle> res = usu.consultarUsuarios($"Name LIKE '%{textBoxNombreUsuario.Text}%'");
                    if (res.Count > 0)
                    {
                        dataGridView1.Rows.Clear();
                        foreach (UsuariosMiddle usu in res)
                        {
                            dataGridView1.Rows.Add(new object[] { usu.id, usu.nombre, usu.correo, usu.telefono, usu.direccion, usu.password });
                            textBoxIDUsuario.Clear();
                            textBoxNombreUsuario.Clear();
                            textBoxNombreUsuario.Enabled = false;
                            textBoxCorreoUsuario.Clear();
                            textBoxDireccion.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente");
                    }
                }
                else
                {
                    MessageBox.Show("Favor de ingresar datos");
                }
            }
        }
    }
}

