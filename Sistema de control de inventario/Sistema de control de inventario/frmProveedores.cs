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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet1.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.inventarioDataSet1.Proveedores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsInventarioNE oclsInventarioNE = new clsInventarioNE();
            dataGridView1.DataSource = oclsInventarioNE.VerProveedor(textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frm = new frmAgregarProveedor();
            frm.Show();
        }
    }
}
