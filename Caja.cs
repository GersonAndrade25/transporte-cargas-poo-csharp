using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_CARGAS__Problema_3._9_
{
    internal class Caja : Cargamento
    {
        //ATRUBUTO DE CLASE CAJA
        private string nombre;
        private double peso ;

        //PROPIEDADES DE CLASE CAJA
        public double Peso { get { return peso; } set { peso = value; } }
        public string Nombre { get { return nombre; }set { nombre = value; } }

        //CONSTRUCTOR DE CAJA   
        public Caja(int cant,double peso,string nombre) : base(cant) 
        {
            Nombre = nombre;
            Peso = peso;
        }

        //METODO PARA SABER EL PESO DE LA UNIDAD O POR CONJUNTO
        public override double PesoTotal()
        {
            return Cantidad * Peso;
        }



        //METODO OVERRIDE STRING TOSTRING 
        public override string ToString()
        {
            return
                $"CAJA" + "\n" +
                $"Contenido: {Nombre}" + "\n" +
                $"Cantidad: {Cantidad} " + "\n" +
                $"Peso por unidad: {Peso}Kg" + "\n" +
                $"Peso Total: {PesoTotal()}Kg";
        }
    }
}
