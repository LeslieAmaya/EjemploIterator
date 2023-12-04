using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIterator
{

    public class Usuario
    {
        static void Main(string[] args)
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo();
            IteradorVehiculo iterador = catalogo.busqueda("economico");
            Vehiculo vehiculo;
            iterador.inicio();
            vehiculo = iterador.item();
            while (vehiculo != null)
            {
                vehiculo.visualiza();
                iterador.siguiente();
                vehiculo = iterador.item();
            }
        }
    }
}
