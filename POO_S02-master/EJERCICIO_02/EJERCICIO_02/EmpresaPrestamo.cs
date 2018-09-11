using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_02
{
    public partial class EmpresaPrestamo : Form
    {
        public EmpresaPrestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String money = cboMoneda.Text;

            double presta = double.Parse(txtMonto.Text);
            double

            if (money=="Soles")
            {
                presta*
            }
            
             
                


            MessageBox.Show(
                "Nombre Del Cliente            "+txtNombre.Text+
                "\nMonto Del Prestamo      S/.   "+txtMonto.Text+
                "\nCantidad de Meses            "+txtMesee.Text+
                "\nTipo de Moneda               "+money+"\n"+
                "================================\n"+
                "Precio a pagar \n================================" + "\n");
        }
    }
}
