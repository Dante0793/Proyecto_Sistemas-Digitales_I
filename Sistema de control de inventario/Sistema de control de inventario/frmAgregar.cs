using Sistema_de_control_de_inventario.Datos;
using Sistema_de_control_de_inventario.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_de_control_de_inventario
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsInventarioNE oclsInventarioNE = new clsInventarioNE();
            int Id = int.Parse(textID.Text);
            if (oclsInventarioNE.ExisteIDProducto(Id) == false)
            {
                oclsInventarioNE.AgregarProducto(Id, textNombre.Text, textDescripcion.Text, textStock.Text, textPreCom.Text, textPreVen.Text);
                MessageBox.Show("Agregado");
            }
            else
            {
                MessageBox.Show("Ya existe ese ID Producto");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textID.Text = string.Empty;
            textNombre.Text = string.Empty;
            textDescripcion.Text = string.Empty;
            textStock.Text = string.Empty;
            textPreCom.Text = string.Empty;
            textPreVen.Text = string.Empty;
        }
    }
}
