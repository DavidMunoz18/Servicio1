using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio1.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("0. cerrar");
            Console.WriteLine("1. ejecutar");
            opcionIntroducida = Console.ReadKey(true).KeyChar - '0';
            return opcionIntroducida;
        }
    }
}
