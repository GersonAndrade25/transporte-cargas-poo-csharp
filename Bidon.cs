using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TRANSPORTE_CARGAS__Problema_3._9_
{
    internal class Bidon : Cargamento
    {
        //ATRIBUTOS DE LA CLASE BIDON
        private double capacidad;
        private double dencidad;
        private string nombre;
        

        //PROPIEDADES DE LA CLASE BIDON 
        public double Capacidad { get { return capacidad;} set { capacidad = value; } }
        public double Dencidad { get {return dencidad;} set { dencidad = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        //CONSTRUCTOR CON PARAMETROS 
        public Bidon(int cant,string nombre, double capacidad, double dencidad) : base(cant)
        { 
            Nombre = nombre;
            Capacidad = capacidad;
            Dencidad = dencidad;
        }

        //METODO PARA SABER EL PESO DEL BIDON
        public double PesoBidon()
        {
            double peso = Capacidad * Dencidad;

            return peso;
        }

        public override double PesoTotal()
        {
            return Cantidad * PesoBidon();
        }

        //METODO OVERRIDE STRING TOSTRING
        public override string ToString()
        {
            return
                "BIDON" + "\n" +
                $"Contenido: {Nombre}" + "\n" +
                $"Cantidad: {Cantidad}" + "\n" +
                $"Peso: {PesoBidon()}Kg" + "\n" +
                $"Peso Total: {PesoTotal()}Kg";
        }
    }
}
