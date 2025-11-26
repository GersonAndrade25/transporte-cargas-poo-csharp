using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_CARGAS__Problema_3._9_
{
    internal class Packing :Cargamento
    {
        //ATRIBUTO DE LA CLASE PACKING
        private double estructuraMadera;
        private Caja cajas;

        //PROPIEDADES DE LA CLASE PACKING
        public double EstructuraMadera { get { return estructuraMadera; } set { estructuraMadera = value; } }
        public Caja Cajas { get { return cajas; }  set { cajas = value; } }

        //CONSTRUCTOR DE LA CLASE PACKING SIN PARAMETROSs
        public Packing(int cant, double estructurabase, Caja cajas):base(cant) 
        { 
            EstructuraMadera = estructurabase;
            Cajas = cajas;
        }

        //METODO PARA CALCULAR EL PESO DE PACKING 
        public override double PesoTotal()
        {
            return EstructuraMadera + (cajas.Cantidad * Cajas.Peso);
        }

        public override string ToString()
        {
            return
                "PACKING" + "\n" +
                $"Contenido: {Cajas.Nombre}" + "\n" +
                $"Cantidad de cajas: {Cajas.Cantidad}" + "\n" +
                $"Peso de la estructura: {EstructuraMadera}" + "\n" +
                $"Peso total: {PesoTotal()}Kg";
        }

    }
}
