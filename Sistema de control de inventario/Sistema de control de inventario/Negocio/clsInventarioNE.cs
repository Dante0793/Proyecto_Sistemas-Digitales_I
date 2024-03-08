using Sistema_de_control_de_inventario.Datos;
using Sistema_de_control_de_inventario.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_de_control_de_inventario.Negocio
{
    internal class clsInventarioNE
    {
        public DataTable BuscarInventario(string nombreproducto)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.BuscarInventario(nombreproducto);
        }
        public DataTable VerDetalle(string nombreproducto)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.VerDetalle(nombreproducto);
        }
        public DataTable VerProveedor(string nombreproducto)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.VerProveedor(nombreproducto);
        }
        public DataTable AgregarProducto(int ID, string nombre, string descripcion, string stock, string precom, string preven)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.AgregarProducto(ID, nombre, descripcion, stock, precom, preven);
        }
        public bool ExisteIDProducto(int ID)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.ExisteIDPRoducto(ID);
        }
        public DataTable AgregarProveedor(int ID, string nombre, string descripcion, string contacto)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.AgregarProveedor(ID, nombre, descripcion, contacto);
        }
        public bool ExisteIDProveedor(int ID)
        {
            clsInventarioDA oclsInventarioDA = new clsInventarioDA();
            return oclsInventarioDA.ExisteIDProveedor(ID);
        }
    }
}