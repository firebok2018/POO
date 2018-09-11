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
    public partial class EmpresaLeonidas : Form
    {
        public EmpresaLeonidas()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            leonidas leo = new leonidas();
            leo.destino = cboDestino.Text;
            leo.tm = double.Parse(txtTM.Text);
/*
            txtTarifa.Text = leo.tarifario().ToString();
            txtFlete.Text = leo.flete().ToString();
            txtSeguro.Text = leo.seguro().ToString();
            txtMonto.Text = leo.monto().ToString();
            */

            MessageBox.Show(
                "Nombre              "+ txtCliente.Text+
                "\nDestino             "+ cboDestino.Text +
                "\nToneladas metricas  " + txtTM.Text+
                "\nTarifa              " + leo.tarifario().ToString()+
                "\nFlete               " + leo.flete().ToString()+
                "\nSeguro              " + leo.seguro().ToString()+
                "\nMonto               " + leo.monto().ToString());

        }
    }
}
