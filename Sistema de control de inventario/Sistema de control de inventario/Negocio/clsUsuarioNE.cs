using Sistema_de_control_de_inventario.Datos;
using Sistema_de_control_de_inventario.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_control_de_inventario.Negocio
{
    public class Usuario
    {
        public static string CreatePasswordHash(string password, string salt)
        {
            // Concatenate password and salt
            string combinedString = string.Concat(password, salt);

            // Create a SHA1 hash
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(combinedString));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Convert to hexadecimal
                }

                return sb.ToString();
            }
        }
        public clsUsuarioEN Autenticar(string nombreusuario, string clave)
        {
            string cPasswordhash = string.Empty;
            clsUsuarioDA oclsUsuarioDA = new clsUsuarioDA();
            clsUsuarioEN oclsUsuarioEN = new clsUsuarioEN();
            oclsUsuarioEN = oclsUsuarioDA.GetPorNombreUsuario(nombreusuario);
            if (oclsUsuarioEN.IdUsuario == 0) //si el id es igual a cero el nombre de usuario no existe
            {
                return oclsUsuarioEN;
            }
            else
            {
                cPasswordhash = CreatePasswordHash(clave, oclsUsuarioEN.Salt.Trim());
                if (cPasswordhash == oclsUsuarioEN.Clave)//preguntara si existe usuario y si la clave/usuario estan bien
                {
                    return oclsUsuarioEN; //el usuario y la contraseña son validos
                }
                else
                {
                    //"El usuario y/o contraseña no son validos. Verifique e intente nuevamente";
                    oclsUsuarioEN.IdUsuario = -1;
                }
            }
            return oclsUsuarioEN;
        }
    }
}
