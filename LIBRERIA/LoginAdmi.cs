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
    public partial class LoginAdmi : Form
    {
        UsuariosMiddle usu = new UsuariosMiddle();
        public LoginAdmi()
        {
            InitializeComponent();
        }

        private void buttonAceptarLoginAdmi_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<UsuariosMiddle> resultado = usu.consultarUsuarios($"Name = 'Admin' AND Password =  '{textBoxPasswordLoginAdmi.Text}'");
            //List<Producto> prods = prod.consultarGeneral($" nombre LIKE '%{txtBuscador.Text}%' OR descripcion LIKE '%{txtBuscador.Text}%'");
            if (resultado.Count > 0)
            {
                Administrador frm = new Administrador();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");
            }
        }

        private void buttonAceptarLoginAdmi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                List<UsuariosMiddle> resultado = usu.consultarUsuarios($"Name = 'Admin' AND Password =  '{textBoxPasswordLoginAdmi.Text}'");
                //List<Producto> prods = prod.consultarGeneral($" nombre LIKE '%{txtBuscador.Text}%' OR descripcion LIKE '%{txtBuscador.Text}%'");
                if (resultado.Count > 0)
                {
                    Administrador frm = new Administrador();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos");
                }
            }
        }
    }
}

