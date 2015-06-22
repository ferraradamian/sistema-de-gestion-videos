using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NProductos
    {
        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DProductos().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }
    }
}
