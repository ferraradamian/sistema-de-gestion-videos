using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Productos : UserControl
    {
        int registrosPorPagina = 25;
        int numeroPagina = 2;

        public Productos()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Mostrar();
        }

        public void Mostrar()
        {
            this.Dock = DockStyle.Fill;
            this.dataGridViewProductos.DataSource = NProductos.Mostrar(numeroPagina, registrosPorPagina);
        }
    }
}
