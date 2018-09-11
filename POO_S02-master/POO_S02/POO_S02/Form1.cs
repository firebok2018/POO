using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_S02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            celima emp = new celima();

            emp.Nombre = txtEmpleado.Text;
            emp.Categoria = txtCategoria.Text;
            emp.SueldoBasico = double.Parse(txtBasico.Text);
            emp.Boinificacion = double.Parse(txtBonificacion.Text);
            emp.tipoa = txtTipAportacion.Text;


            txtRemuneracion.Text = emp.remuneracion().ToString();
            txtMontoAportacion.Text = emp.aportacion().ToString();
            txtNeto.Text = emp.Neto().ToString();

            MessageBox.Show(
                "Empleado__________________________ "+ txtEmpleado.Text+
                "\n Categoria______________________ "+txtCategoria.Text+
                "\n Sueldo Basico__________________"+txtBasico.Text+
                "\n Bonificación___________________ "+txtBonificacion.Text+
                "\n Tipo de Aportacion_____________ "+txtTipAportacion.Text+
                "\n Remuneración___________________"+emp.aportacion().ToString());
           
        }
    }
}
