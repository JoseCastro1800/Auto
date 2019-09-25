using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovil
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo productox = new Vehiculo();
            productox.Ver_producto(productox);
            productox.Id = 56568;
            productox.Nombre = "Tacoma";
            productox.Tipo = "Todo terreno";
            productox.Marca = "Toyota";
            productox.Annio = 2019;

  


            Console.Write(productox.Id + "-" + productox.Nombre + "-" + productox.Tipo + "-" + productox.Marca + "-" + productox.Annio);
            Console.ReadKey();

         
        }
    }

    }

       



