using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_CARGAS__Problema_3._9_
{
    internal abstract class Cargamento
    {
        //ATRIBUTOS DE LA CLASE CARGAMENTO
        protected int cantidad;

        //lista
        public List<Cargamento> registrodeCarga = new List<Cargamento>();

        //PROPIEDADES DE LA CLASE CARGAMENTO
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }

        //CONSTRUCTOR CON PARAMETROS 
        public Cargamento(int cant)
        { 
            Cantidad = cant; 
            registrodeCarga.Add(this);
        }

        public abstract double PesoTotal();

        /*----------------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*----------------------------------------------------------------------------------------------------------------------------------------------------------*/

    }
}
