using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TRANSPORTE_CARGAS__Problema_3._9_
{
    internal class Camion
    {
        //ATRIBUTOS DE LA CLASE CAMION
        private int cargamaxima;
        private Cargamento cargamentos;
        
        //LISTAS QUE USARE PARA RESOLVER EL PROBLEMA
        public List<Cargamento> Contenedor = new List<Cargamento>();

        //PROPIEDADES DE LA CLASE CAMION
        public int CargaMaxima { get { return cargamaxima; } set { cargamaxima = value; } }
        public Cargamento Cargamentos { get { return cargamentos; } }

        //CONSTRUCTOR DE LA CLASE CAMION 
        public Camion(int cargamax)
        { 
            CargaMaxima = cargamax;
        }

        //metodo para ver la carga
        public void MostrarCarga()
        {
            foreach (Cargamento i in Contenedor)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("---------------------------------------------------------");
            }
        }


        /*----------------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*----------------------------------------------------------------------------------------------------------------------------------------------------------*/


        //--------------- consigna uno subir cargamneto --------------------------------//
        public void SubirCarga(Cargamento unCargamento)
        {
            Contenedor.Add(unCargamento);
        }

        public void VerificarPeso()
        {
            double sumacarga = 0; 
            for (int i = 0; i < Contenedor.Count; i++)
            {
                sumacarga = sumacarga + Contenedor[i].PesoTotal();         
            }

            if (sumacarga < CargaMaxima)
            {
                double espaciorestante = CargaMaxima - sumacarga;
                Console.WriteLine($"El contenedor tiene aun espacio , puede agregar algo con un peso de {espaciorestante}Kg");
            }
            else if (sumacarga == CargaMaxima)
            {
                Console.WriteLine("El camion esta lleno");
            }
            else
            {
                double sobrepeso = sumacarga - CargaMaxima;
                Console.WriteLine($"El camion esta siendo sobrecargado y se pasa por {sobrepeso}Kg");
            }
        }

        //-------------------- consigina 2 bajar cargamento -------------------------------//

        public void BajarCarga(Cargamento unCargamento)
        {
            Contenedor.Remove(unCargamento);

            MostrarCarga();
            Console.WriteLine("SE RETIRO: ");
            Console.WriteLine($"{unCargamento}");
            
        }


        //-------------------- consigina 3  datos del contenedor en todo momento -------------------------------//

        public void DatosCargamento()
        {
            double sumacarga = 0;
            int carga = 0;
            for (int i = 0; i < Contenedor.Count; i++)
            {
                sumacarga = sumacarga + Contenedor[i].PesoTotal();
                carga = carga + Contenedor[i].registrodeCarga.Count;

            }

            Console.WriteLine($"Hay un total de {carga} cargas  y con un peso total de {sumacarga} Kg");
        }

        //-------------------- consigina 4 saber si el camion esta listo para partir -------------------------------//
        public double calculoPorcentaje(double a , double b)
        {
            return (a * 100) / b;
        }
        public void ListoParaPartir()
        {
            double sumacarga1 = 0;
            for (int i = 0; i < Contenedor.Count; i++)
            {
                sumacarga1 = sumacarga1 + Contenedor[i].PesoTotal();
            }

            if (calculoPorcentaje(sumacarga1, CargaMaxima) >= 75)
            {
                Console.WriteLine($"El camion esta listo para partir");
            }
            else { Console.WriteLine("Aun no esta listo para partir"); }
        }
    }
}
