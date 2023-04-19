using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA
{
    public partial class Administrador : Form
    {
        private Form activeForm = null;
        private void openAdmiForms(Form AdmiForms)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = AdmiForms;
            AdmiForms.TopLevel = false;
            AdmiForms.FormBorderStyle = FormBorderStyle.None;
            AdmiForms.Dock = DockStyle.Fill;
            panelAmdiForm.Controls.Add(AdmiForms);
            panelAmdiForm.Tag = AdmiForms;
            AdmiForms.BringToFront();
            AdmiForms.Show();


        }
        public Administrador()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Usuarios());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Agregar());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Editarcs());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Consulta());
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Aqua;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Empty;
        }

        private void PanelAgregar_MouseClick(object sender, MouseEventArgs e)
        {
            openAdmiForms(new Agregar());
        }

        private void btnUsuarios_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Usuarios());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Agregar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Editarcs());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            openAdmiForms(new Consulta());
        }

        private void btnSalirAdmi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
