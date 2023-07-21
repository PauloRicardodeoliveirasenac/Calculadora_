using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
     class Controlcalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora = new ModelCalculadora();

        public Controlcalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetnum1 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetnum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar
        public int Menu()
        {
            Console.WriteLine("----menu----"                               +
                             "\n.0 Sair"                                   +
                             "\n1. Somar"                                  +
                             "\n2. Subtrair"                               +
                             "\n3. Dividir"                                +
                             "\n4. Multpilicar"                            +
                             "\n5. potencia"                               +
                             "\n6. raiz"                                   +
                             "\n7. tabuada"                                +
                             "\n.8 conversão binário para decimal"         +
                             "\n.9 ConvertBinaryToDecimal"                 +
                             "\n.10 conversão binário para hexadecimal"    +
                             "\n.11 conversão hexadecimal  para decimal"   +
                             "\n.12 contaBhaskara"                         +
                             "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }// fim do metodo menu
        public void Operacao()
        {
            int opcao = 0;
            do
            {
                 opcao = Menu();
                Console.Clear();//limpa a tela
                switch (opcao)
                {

                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        coletar();
                        Console.WriteLine("Soma: " + this.calculadora.somar());
                        break;
                    case 2:
                        coletar();
                        Console.WriteLine("subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        coletar();
                        if (this.calculadora.Dividir() == -1)
                        {

                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;

                    case 4:
                        coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;

                    case 5:
                        coletar();
                        Console.WriteLine("potencia: " + this.calculadora.Potencia());
                        break;

                    case 6:
                        coletar();
                        Console.WriteLine("raiz: " + this.calculadora.Raiz());
                        break;

                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetnum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.Tabuadanum1());
                        break;

                    case 8:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetnum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.Tabuadanum2());
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;

                    case 12:
                        coletar();
                        if (this.calculadora.x1() == -1)
                        {
                            Console.WriteLine("DELTA Negativo!");
                        }
                        else
                        {
                            Console.WriteLine("DELTA: " + this.calculadora.DELTA());
                            Console.WriteLine("x1: " + this.calculadora.x1());
                            Console.WriteLine("x2: " + this.calculadora.x2());
                        }
                        break;
                        
                }
            } while (opcao != 0);//fim do... while
        }
            }//fim do switch
        }//fim do operacao

