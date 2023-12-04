using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploIterator
{
    public class CatalogoVehiculo : Catalogo<Vehiculo,
  IteradorVehiculo>
    {

        public CatalogoVehiculo()
        {
            contenido.Add(new Vehiculo("vehiculo economico"));
            contenido.Add(new Vehiculo("pequeño vehiculo economico"));
            contenido.Add(new Vehiculo("vehoculo de gran calidad"));
        }
    }

}
