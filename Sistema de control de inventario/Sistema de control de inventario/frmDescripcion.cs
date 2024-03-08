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
    public partial class frmDescripcion : Form
    {
        public frmDescripcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsInventarioNE oclsInventarioNE = new clsInventarioNE();
            dataGridView1.DataSource = oclsInventarioNE.VerDetalle(textBox1.Text);
            
        }

        private void frmDescripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet2.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.inventarioDataSet2.Productos);

        }
    }
}
