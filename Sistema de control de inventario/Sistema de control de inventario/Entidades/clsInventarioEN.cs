using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_control_de_inventario.Entidades
{
    public class clsInventarioEN
    {
        public int Id_Inventario { get; set; }
        public int Id_Producto { get; set; }
        public string Fecha_Ingreso { get; set; }
        public string Cantidad_Stock { get; set; }
    }
}
