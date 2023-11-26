using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIterator
{
    public class Vehiculo : Elemento
    {
        public Vehiculo(string descripcion) : base(descripcion) { }

        public void visualiza()
        {
            Console.WriteLine("Descripción del vehículo: " +
              descripcion);
        }
    }

}
