using Sistema_de_control_de_inventario.Entidades;
using Sistema_de_control_de_inventario.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_control_de_inventario
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario oclsUsuario = new Usuario();
            clsUsuarioEN oclsUsuarioBE = oclsUsuario.Autenticar(textBoxUser.Text, textPassword.Text);
            if (oclsUsuarioBE.IdUsuario > 0)
            {
                frmInventario frm = new frmInventario();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("credenciales invalidas");
            }
        }
    }
}
