using Microsoft.Data.SqlClient;
using Sistema_de_control_de_inventario.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_control_de_inventario.Datos
{
    public class clsInventarioDA : clsInventarioEN
    {
        private string cadenaDeConexion = ConfigurationManager.ConnectionStrings["Sistema_de_control_de_inventario"].ConnectionString;
        public clsInventarioDA()
        {
            cadenaDeConexion = ConfigurationManager.ConnectionStrings["Sistema_de_control_de_inventario"].ConnectionString;
        }
        public DataTable BuscarInventario(string nombreproducto)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                //string consulta = "SELECT * FROM Inventario WHERE Id_Producto = @Id_Producto";
                string consulta = "select i.ID_Producto, Productos.Nombre, Cantidad_Stock, Productos.Precio_compra, Productos.Precio_venta " +
                "from Inventario i join Productos on i.ID_Producto = Productos.ID_Producto where Productos.Nombre like '%" + nombreproducto + "%';";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaDeConexion);
                adaptador.Fill(dt);
            }
            return dt;
        }
        public DataTable VerDetalle(string nombre)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                //string consulta = "SELECT * FROM Inventario WHERE Id_Producto = @Id_Producto";
                string consulta = "select Productos.Nombre, Productos.Descripcion from Productos where Productos.Nombre like '%" + nombre + "%';";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaDeConexion);
                adaptador.Fill(dt);
            }
            return dt;
        }
        public DataTable VerProveedor(string nombre)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                //string consulta = "SELECT * FROM Inventario WHERE Id_Producto = @Id_Producto";
                string consulta = "select p.Nombre, p.Contacto, p.Descripcion from Proveedores p where p.Nombre like '%" + nombre + "%';";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaDeConexion);
                adaptador.Fill(dt);
            }
            return dt;
        }
        public DataTable AgregarProducto(int ID ,string nombre,string descripcion,string stock,string precom,string preven)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                //string consulta = "SELECT * FROM Inventario WHERE Id_Producto = @Id_Producto";
                string consulta = "INSERT INTO Productos (ID_Producto, Nombre, Descripcion, Precio_venta, Precio_compra) VALUES ("+ ID +", '"+ nombre +"', '"+ descripcion +"',"+ preven +", "+ precom +");" +
                    "INSERT INTO Inventario (ID_Inventario, ID_Producto, Fecha_Ingreso, Cantidad_Stock) VALUES("+ ID+1 +","+ ID +", GETDATE() ,"+ stock +");";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaDeConexion);
                adaptador.Fill(dt);
            }
            return dt;
        }
        public bool ExisteIDPRoducto(int ID)
        {
            bool existe;

            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                string consulta = "select i.ID_Producto from inventario i join Productos p on i.ID_Producto = p.ID_Producto where i.ID_Producto = '"+ ID +"';";

                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);

                    // Utilizamos ExecuteScalar para obtener la cantidad de filas que cumplen la condición
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si la cantidad es mayor que cero, significa que el ID existe en la base de datos
                    if (cantidad == ID)
                    {
                        existe = true;
                    }   
                    else
                    {
                       existe = false;
                    }
                }
            }
            return existe;
        }
        public DataTable AgregarProveedor(int ID, string nombre, string descripcion, string contacto)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                //string consulta = "SELECT * FROM Inventario WHERE Id_Producto = @Id_Producto";
                string consulta = "INSERT INTO Proveedores (ID_Proveedor, Nombre, Descripcion, Contacto) VALUES (" + ID + ", '" + nombre + "', '" + descripcion + "'," + contacto + ");";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cadenaDeConexion);
                adaptador.Fill(dt);
            }
            return dt;
        }
        public bool ExisteIDProveedor(int ID)
        {
            bool existe;

            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();

                string consulta = "select p.ID_Proveedor from Proveedores p where p.ID_Proveedor = '" + ID + "';";

                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);

                    // Utilizamos ExecuteScalar para obtener la cantidad de filas que cumplen la condición
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si la cantidad es mayor que cero, significa que el ID existe en la base de datos
                    if (cantidad == ID)
                    {
                        existe = true;
                    }
                    else
                    {
                        existe = false;
                    }
                }
            }
            return existe;
        }
    }
}

