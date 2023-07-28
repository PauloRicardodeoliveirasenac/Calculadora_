using calculadora;
using Calculadora1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCalculadora control = new ControlCalculadora();
            control.Operacao();
            Console.ReadLine();//manter o prompt abeerto
        }//fim do metodo main
}//fim do class progam
}//fim do projteto calculadora
