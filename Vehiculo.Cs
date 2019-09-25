using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovil
{
    public class Vehiculo
    {
        private int id;
        private string nombre;
        private string tipo;
        private string marca;
        private int annio;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        public string Marca
        {
            get { return marca; }
            set { marca = value; }

        }

        public int Annio
        {
            get { return annio; }
            set { annio = value; }
        }
        
        public void Ver_producto(Vehiculo productox)
        {
            Console.WriteLine("Ver producto");
        }

        public void Ver_productoe(Vehiculo productoe)
        {
            Console.WriteLine("Ver producto");
        }
    }
}
