using Servicio1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio1
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void suma(int k)
        {
            int n;
            for (int i = 1; i < k+1; i++) 
            {
                n = i + i -1;
                Console.WriteLine(i + ": " + n);
            }
        }
    }
}
