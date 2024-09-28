using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDelegado2
{
    class Program
    {
        static void Main(string[] args)
        {
            saludoDelegado creacionDelegado = new saludoDelegado(Bienvenida.SaludoBienvenida);

            creacionDelegado();

            Console.ReadKey();

            creacionDelegado = new saludoDelegado(Despedida.SaludoDespedida);

            creacionDelegado();

            Console.ReadKey();
        }

        delegate void saludoDelegado();
    }

    class Bienvenida
    {

        public static void SaludoBienvenida()
        {
            Console.WriteLine("Este es un saludo de bienvenida...");
        }

    }

    class Despedida
    {

        public static void SaludoDespedida()
        {
            Console.WriteLine("Este es un saludo de despedida...");
        }
    }
}
