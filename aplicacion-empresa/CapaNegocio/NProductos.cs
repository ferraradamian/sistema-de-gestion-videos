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
        public static DataTable Mostrar(int parRegistrosPorPagina, int parNumeroPagina)
        {
            return new DProductos().Mostrar(parRegistrosPorPagina, parNumeroPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DProductos().Tamaño(parRegistrosPorPagina);
        }
    }
}
