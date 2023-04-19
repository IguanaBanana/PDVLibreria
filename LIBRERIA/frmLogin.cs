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
    public partial class frmLogin : Form
    {
        UsuariosMiddle usu = new UsuariosMiddle();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBoxUsuarioLoginUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmiLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdmi frm = new LoginAdmi();
            frm.Show();
        }

        public void buttonAceptarLoginUsu_Click(object sender, EventArgs e)
        {

            List<UsuariosMiddle> resultado = usu.consultarUsuarios($"Nombre =  '{textBoxUsuarioLoginUsu.Text}' AND Password =  '{textBoxPasswordLoginUsu.Text}'");
            //List<Producto> prods = prod.consultarGeneral($" nombre LIKE '%{txtBuscador.Text}%' OR descripcion LIKE '%{txtBuscador.Text}%'");
            if (resultado.Count > 0)
            {   textBoxPasswordLoginUsu.Clear();
                textBoxUsuarioLoginUsu.Clear();
                Venta frm = new Venta();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");
            }
        }
    }
}