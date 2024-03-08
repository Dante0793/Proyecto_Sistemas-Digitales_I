using Microsoft.Data.SqlClient;
using Sistema_de_control_de_inventario.Entidades;
using Sistema_de_control_de_inventario.Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_control_de_inventario.Datos
{
    internal class clsUsuarioDA:clsUsuarioEN
    {
        private string cadenaDeConexion;
        public clsUsuarioDA()
        {
            cadenaDeConexion = ConfigurationManager.ConnectionStrings["Sistema_de_control_de_inventario"].ConnectionString;
        }
        public clsUsuarioEN GetPorNombreUsuario(string nombreusuario)
        {
            clsUsuarioEN oclsUsuarioEN = new clsUsuarioEN();
            oclsUsuarioEN.IdUsuario = 0;//si el usuario no existe su id sera igual a cero
            using (SqlConnection conn = new SqlConnection(cadenaDeConexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Usuario where NombreUsuario='"
                    + nombreusuario + "';", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        oclsUsuarioEN.IdUsuario = Convert.ToInt32(reader["IdUsuario"].ToString());
                        oclsUsuarioEN.NombreUsuario = reader["NombreUsuario"].ToString();
                        oclsUsuarioEN.Clave = reader["Clave"].ToString();
                        oclsUsuarioEN.Salt = reader["Salt"].ToString();
                    }
                }
            }
            return oclsUsuarioEN;
        }
    }
}
