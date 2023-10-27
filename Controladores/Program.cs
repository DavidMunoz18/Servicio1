using Servicio1.Servicios;

namespace Servicio1
{
    class program
    {
        static void Main(String[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            {
                bool cerrarMenu = false;
                int opcionIntroducida;
                while(!cerrarMenu)
                {
                    opcionIntroducida = menu.mostrarMenuYSeleccion();
                    switch (opcionIntroducida)
                    {
                        case 0:
                            cerrarMenu |= true;
                            break;
                            case 1:
                            Console.WriteLine("Escriba un entero");
                            int valor = Convert.ToInt32(Console.ReadLine());

                            oi.suma(valor);

                            break;
                    }
                }
            }
        }
    }
}