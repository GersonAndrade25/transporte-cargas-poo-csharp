using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_CARGAS__Problema_3._9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CARGAMENTO 
            Caja C1 = new Caja(4, 25, "Notebook ASUS");
            Caja C2 = new Caja(1, 25, "Notebook Lenovo");

            Packing P1 =  new Packing(2,10,C1);// este packing se arma con las cajas de  caja C1

            Bidon B1 = new Bidon(1,"Agua",30,15);


            //CAMIONES 
            Camion Ca1 = new Camion(500);

            /*----------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*----------------------------------------------------------------------------------------------------------------------------------------------------------*/

            //--------------- consigna uno subir cargamneto --------------------------------//
            Ca1.SubirCarga(C2);

            Ca1.MostrarCarga();
            Ca1.VerificarPeso();
            Console.WriteLine("");
            Console.WriteLine("");

            //-------------------- consigina 2 bajar cargamento -------------------------------//
            //Ca1.BajarCarga(C1);

            
            //-------------------- consigina 3  datos del contenedor en todo momento -------------------------------//
            Console.WriteLine("");
            Ca1.DatosCargamento();
            Console.WriteLine("");
            Console.WriteLine("");


            //-------------------- consigina 4 saber si el camion esta listo para partir -------------------------------//
            Ca1.ListoParaPartir();

            Console.ReadKey();
        }


    }
}
