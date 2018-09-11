using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIVECA
{
    public partial class Form1 : Form
    {
        List<personal> seleccion = new List<personal>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            
            txtDNI.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            personal p = seleccion.Find(x => x.DNI == txtDNI.Text);
            if (p==null)
            {
                
                personal pe = new personal();
               
                pe.DNI = txtDNI.Text;
                pe.nombre = txtNombre.Text;
                pe.apellido = txtApellidos.Text;
                pe.direccion = txtDireccion.Text;
                pe.fechaNac = dtpfecha.Text;

                seleccion.Add(pe);


                dgpersonal.DataSource = null;
                dgpersonal.DataSource = seleccion;
            }else
            {
                MessageBox.Show("YA existe Ingrese Otro NUmero De Dni");
            }

          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            personal p = seleccion.Find(x => x.DNI == txtDNI.Text);

            if (p!=null )
            {
                seleccion.Remove(p);

                dgpersonal.DataSource = null;
                dgpersonal.DataSource = seleccion;
            }
            else
            {
                MessageBox.Show("DNi no existe");
            }

            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            personal p = seleccion.Find(x => x.DNI == txtDNI.Text);
            if (p != null)
            {
              
                p.nombre = txtNombre.Text;
                p.apellido = txtApellidos.Text;
                p.direccion = txtDireccion.Text;
                p.fechaNac = dtpfecha.Text;

                


                dgpersonal.DataSource = null;
                dgpersonal.DataSource = seleccion;
            }
            else
            {
                MessageBox.Show("Dato no Existente");
            }
        }
    }
}
