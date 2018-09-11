using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_S02
{
    public class celima{

        private String nombre, categoria, tipAportacion ;
        
        private double sueldoBasico,Bonificacion;

    
        public double SueldoBasico
        {
            get { return sueldoBasico; }
            set { sueldoBasico = value; }
        }
        public string Nombre
        {
            get{ return nombre; }
            set{ nombre = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public double Boinificacion
        {
            get { return Bonificacion; }
            set { Bonificacion = value; }
        }
        public string tipoa
        {
            get { return tipAportacion; }
            set { tipAportacion = value; }
        }
        public celima()
        {
            sueldoBasico = 0;
            Bonificacion = 0;


        }
        public double remuneracion()
        {
            return sueldoBasico + Bonificacion;
        }
  
        public double aportacion( )
        {
          
            if (tipAportacion=="AFP")
            {
                return remuneracion()*0.11;
            }
            else{
                return remuneracion() * 0.13;
            }
        }
        public double Neto()
        {
            return remuneracion() + aportacion();
        }

    
    }
}
