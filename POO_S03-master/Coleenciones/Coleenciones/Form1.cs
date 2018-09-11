using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coleenciones
{
    public partial class txtEmail : Form
    {
        List<Participante> consurso = new List<Participante>();

        public txtEmail()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Participante p = consurso.Find(x => x.DNI == txtDni.Text);
            if (p==null)
            {
               
                Participante p1 = new Participante();
                p1.DNI = txtDni.Text;
                p1.nombre = txtNOmbre.Text;
                p1.apellido = txtApellido.Text;
                p1.telefono = txtTelfono.Text;
                p1.email = txtema.Text;

                consurso.Add(p1);
            }
            else
            {
                MessageBox.Show("Ya existe");
            }
           

        
          
           

            dgParticipantes.DataSource = null;
            dgParticipantes.DataSource = consurso;
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Participante p = consurso.Find(x => x.DNI == txtDni.Text);

           if( p != null)
            {
                p.nombre = txtNOmbre.Text;
                p.apellido = txtApellido.Text;
                p.telefono = txtTelfono.Text;
                p.email = txtema.Text;

                dgParticipantes.DataSource = null;
                dgParticipantes.DataSource = consurso;
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }
    }
}
