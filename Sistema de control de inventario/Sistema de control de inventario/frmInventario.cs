using Microsoft.Data.SqlClient;
using Sistema_de_control_de_inventario.Datos;
using Sistema_de_control_de_inventario.Entidades;
using Sistema_de_control_de_inventario.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_control_de_inventario
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {           
            this.inventarioTableAdapter.Fill(this.inventarioDataSetInventario.Inventario);
            this.productosTableAdapter.Fill(this.inventarioDataSetInventario.Productos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsInventarioNE oclsInventarioNE = new clsInventarioNE();
            dataGridView1.DataSource = oclsInventarioNE.BuscarInventario(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDescripcion frm = new frmDescripcion();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAgregar frm = new frmAgregar();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clsInventarioNE oclsInventarioNE = new clsInventarioNE();
            dataGridView1.DataSource = oclsInventarioNE.BuscarInventario(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReporte frm = new frmReporte();
            frm.Show();
        }
    }
}
