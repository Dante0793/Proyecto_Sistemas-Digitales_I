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
    public partial class frmAgregarProveedor : Form
    {
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void frmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsInventarioNE oclsInventarioNE = new clsInventarioNE();
            int Id = int.Parse(textID.Text);
            if (oclsInventarioNE.ExisteIDProveedor(Id) == false)
            {
                oclsInventarioNE.AgregarProveedor(Id, textNombre.Text, textDescripcion.Text, textContacto.Text);
                MessageBox.Show("Agregado");
            }
            else
            {
                MessageBox.Show("Ya existe ese ID Proveedor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textID.Text = string.Empty;
            textNombre.Text = string.Empty;
            textContacto.Text = string.Empty;
            textDescripcion.Text = string.Empty;
        }
    }
}
