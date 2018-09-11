using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa_FULLCOPY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullCopy fc = new FullCopy();

            fc.cliente = txtnombre.Text;
            fc.descripcion = txtDescripcion.Text;
            fc.tipo = cboTipo.Text;
            fc.cantidad = int.Parse(txtCantidad.Text);

            txtMonto.Text = fc.monto().ToString();
            txtTarifa.Text = fc.tarifa.ToString();
        }
    }
}
