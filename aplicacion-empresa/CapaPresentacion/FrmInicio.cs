using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        Productos controlProductos;

        public FrmInicio()
        {
            InitializeComponent();
            controlProductos = new Productos();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(controlProductos);
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            Pedidos controlPedidos = new Pedidos();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(controlPedidos);
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Clientes controlClientes = new Clientes();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(controlClientes);
        }

        private void buttonTransporte_Click(object sender, EventArgs e)
        {
            Transporte controlTransporte = new Transporte();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(controlTransporte);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            Empleados controlEmpleados = new Empleados();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(controlEmpleados);
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            Categorias controlCategorias = new Categorias();
            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(controlCategorias);
        }
    }
}
