using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controlcalculadora control = new Controlcalculadora();
            control.Operacao();
            Console.ReadLine();//manter o prompt abeerto
        }//fim do metodo main
    }//fim do class progam
}//fim do projteto calculadora
