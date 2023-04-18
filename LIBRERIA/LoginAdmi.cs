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
    public partial class LoginAdmi : Form
    {
        UsuariosMiddle usu = new UsuariosMiddle();
        public LoginAdmi()
        {
            InitializeComponent();
        }

        private void buttonAceptarLoginAdmi_Click(object sender, EventArgs e)
        {

            List<UsuariosMiddle> resultado = usu.consultarUsuarios($"Nombre = 'Administrador' AND Password =  '{textBoxPasswordLoginAdmi.Text}'");
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
