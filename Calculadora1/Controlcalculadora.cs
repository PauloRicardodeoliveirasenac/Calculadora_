using calculadora;
using exercicosprogramacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace calculadora
{
    class ControlCalculadora
    {


        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public int Menu()
        {
            Console.WriteLine("------ Menu -------" +
                              "\n0.Sair" +
                              "\n\n\nCALCULADORA " +
                              "\n1.Somar" +
                              "\n2.Subtrair" +
                              "\n3.Dividir" +
                              "\n4.Multiplicar" +
                              "\n5 Potência" +
                              "\n6 Raiz" +
                              "\n7.Tabuada" +
                              "\n8.binário para decimal" +
                              "\n9.decimal para binário" +
                              "\n10.Hexadecimal para decimal " +
                              "\n11.Decimal para Hexadecimal" +
                              "\n12.Bhaskara" +
                              "\n13.binario para hexadecimal " +
                              "\n\n\nExercícios de Programação: " +
                              "\n.14 exercicio 1" +
                              "\n.15 exercicio 2" +
                              "\n.16 exercicio 3" +
                              "\n.17 exercicio 4" +
                              "\n.18 exercicio 5" +
                              "\n.19 exercicio 6" +
                              "\n.20 exercicio 7" +
                              "\n.21 exercicio 8" +
                              "\n.22 exercicio 9" +
                              "\n.23 exercicio 10" +
                              "\n.24 exercicio 11" +
                              "\n.25 exercicio 12" +
                              "\n.26exercicio 13" +
                              "\n.7 exercicio 14" +
                              "\n.28 exercicio 15" +
                              "\n.29 exercicio 16" +
                              "\n.30 exrcicio 17" +
                              "\n.31vercicio 18" +
                              "\n.32 exercicio1 9" +
                              "\n.33 exercicio20" +
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {


                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
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
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;
                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;
                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;
                    case 13:
                        Console.WriteLine("Informe um valor binário: ");
                        string binario = Console.ReadLine();
                        Console.WriteLine(this.calculadora.ConverterBinarioHexadecimal(binario));
                        break;
                    case 14:
                        Console.WriteLine("Digite um número:");
                        int numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dobro: " + (numero * 2));
                        Console.WriteLine("Triplo: " + (numero * 3));
                        Console.ReadLine();
                        break;
                    case 15:
                        Coletar();
                        Console.WriteLine("O salario atual com 30% a mais é : " + this.calculadora.exercicio2());
                        break;

                    case 16:
                        Console.Write("Informe um número: ");
                        int number = int.Parse(Console.ReadLine());
                        ModelCalculadora numberHelper = new ModelCalculadora();
                        string result = numberHelper.NumeroNegPos(number);
                        Console.WriteLine(result);
                        break;
                    case 17:
                        ModelCalculadora modelCalculadora = new ModelCalculadora();
                        int comeco = 1;
                        int fim = 100;
                        int soma = modelCalculadora.exercicio4(comeco, fim);
                        Console.WriteLine($"A soma dos números inteiros de {comeco} a {fim} é: {soma}");
                        break;
                    case 18:
                        Coletar();
                        Console.WriteLine("Informe um numero: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.exercicio5());
                        break;
                    case 19:
                        Coletar();
                        Console.WriteLine(this.calculadora.exercicio6());
                        break;
                    case 20:
                        Console.WriteLine(this.calculadora.exercicio7());
                        break;
                    case 21:
                        Console.WriteLine(this.calculadora.exercicio8());
                        break;
                    case 22:
                        Console.WriteLine("Soma dos números até digitar 0: " + this.calculadora.execicio9());
                        break;
                    case 23:
                        double media = this.calculadora.exercicio10();
                        if (media != 0)
                            Console.WriteLine("Média dos números pares: " + media);
                        break;
                    case 24:

                        break;



                }
            } while (opcao != 0);//fim do while 
        }
    }//fim da classe 
}//fim do projeto