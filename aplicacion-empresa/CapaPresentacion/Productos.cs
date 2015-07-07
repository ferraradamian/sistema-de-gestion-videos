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
        int numeroPagina = 1;
        int cantidadPaginas;

        public Productos()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            Mostrar();
        }

        public void Mostrar()
        {
            this.dataGridViewProductos.DataSource = NProductos.Mostrar(registrosPorPagina, numeroPagina);
            cantidadPaginas = NProductos.Tamaño(registrosPorPagina);
            this.labelPaginacion.Text = String.Format("Página {0} de {1}", numeroPagina, cantidadPaginas);
        }

        public void Buscar()
        {
            try
            {
                this.dataGridViewProductos.DataSource = NProductos.Buscar(this.textBoxNombreBuscar.Text);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Refrescar()
        {
            this.numeroPagina = 1;
            this.Mostrar();
            this.textBoxNombreBuscar.Text = String.Empty;
        }

        private void buttonPaginacionAtras_Click(object sender, EventArgs e)
        {
            if (numeroPagina > 1)
            {
                numeroPagina = numeroPagina - 1;
                Mostrar();
            }
        }

        private void buttonPaginacionSiguiente_Click(object sender, EventArgs e)
        {
            if (numeroPagina < cantidadPaginas)
            {
                numeroPagina = numeroPagina + 1;
                Mostrar();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto nuevoProducto = new FrmAgregarProducto();
            nuevoProducto.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            FrmEditarProducto editarProducto = new FrmEditarProducto();
            editarProducto.ShowDialog();
        }

        private void textBoxNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNombreBuscar.Text == String.Empty)
            {
                this.numeroPagina = 1;
                this.Mostrar();
                this.tableLayoutPanelPaginacion.Show();
            }
            else
            {
                this.Buscar();
                this.tableLayoutPanelPaginacion.Hide();
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }

            
    }
}
