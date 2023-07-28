using System.Linq;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace calculadora
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
        }//fim do construtor

        //Métodos Gets e Sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim do GetSetNum2

        //Métodos
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do método somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do método subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//fim do método dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do método multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potência

        public string Raiz()
        {
            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }//fim do método raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public string TabuadaNum2()
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public int ConverterDecimal(string binario)
        {
            int dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Convert.ToInt32(Math.Pow(2, pote));
                }
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while (dec != 0);
            return new String(binario.Reverse().ToArray());
        }//fim do método

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while (dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2;
            }
        }//fim do bhaskara

        public string ConverterBinarioHexadecimal(string binario)
        {

            int dec = ConverterDecimal(binario);
            string hex = ConverterDecimalHexa(dec);
            return hex;
        }//fim do metodo ConverterBinarioHexadecimal

        ////////////////////// EXERCICIOS PROGRAMACAO //////////////////////////////


        public void exercicio1()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int dobro = numero * 2;
            int triplo = numero * 3;

            Console.WriteLine($"O dobro do número digitado é: {dobro}");
            Console.WriteLine($"O triplo do número digitado é: {triplo}");
        }//fim do exercicio1

        public string exercicio2()
        {

            return "O salario aumnetado em 30% é" + (GetSetNum1 * 30 / 100);

        }//fim do exercicio 2

        public string NumeroNegPos(int num)
        {
            string result = "O número ";

            if (num > 0)
                result += "é positivo ";
            else if (num < 0)
                result += "é negativo ";
            else
                result += "é zero.";

            if (num % 2 == 0)
                result += "e o numero é par.";
            else
                result += "e o numero é ímpar.";

            return result;
        }// fim do Exercicio 3

        public int exercicio4(int comeco, int fim)
        {
            int soma = 0;
            for (int i = comeco; i <= fim; i++)
            {
                soma += i;
            }
            return soma;
        }// fim do Exercicio 4

        public string exercicio5()
        {
            string resultado = "";

            for (int i = 1; i <= GetSetNum1; i++)// i++ é uma variavel acumuladora ex i+3 vai contando de 3 em 3 
            {
                resultado += "\n" + 1 + " * " + i + " = " + (1 * i); //+= serve para concatenar a linha ao inves de colocar resultado = resultado
            }//Fim do método For

            return resultado;
        }// Fim do exercicio 5

        public string exercicio6()
        {
            string resultado = "";

            for (int i = 1; i <= GetSetNum2; i++)
            {
                resultado += "\n" + (GetSetNum1 + (1 * i - GetSetNum1));
            }//Fim do método for

            return resultado;
        }//fim do exercicio 6

        public string exercicio7()
        {
            string resultado = "";

            // Laço for para percorrer os números de 100 a 200
            for (int i = 101; i <= 199; i += 2)
            {
                Console.WriteLine(i);
            }
            return resultado;

        }//fim do exercicio 7 

        public int exercicio8()
        {
            int contador = 0;
            int numS;

            //Início;Fim;Contagem
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                numS = Convert.ToInt32(Console.ReadLine());

                contador += numS;
            }//fim do for

            return contador;
        }//Fim do exercicio 8

        public int execicio9()
        {
            int soma = 0;
            Console.WriteLine("Informe numeros Inpares(Para parar digite 0)");
            while (true)
            {
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 == 0)
                    break;

                soma += num1;
            }
            return soma;

        }//fim do exercicio 9

        public double exercicio10()
        {
            int soma = 0;
            int quantidadePares = 0;

            Console.WriteLine("Informe numeros Pares(Para parar digite 0)");

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                    break;

                if (num % 2 == 0)
                {
                    soma += num;
                    quantidadePares++;
                }
            }

            if (quantidadePares == 0)
            {
                Console.WriteLine("Nenhum número par foi digitado.");
                return 0;
            }

            double media = (double)soma / quantidadePares;
            return media;

        }//Fim do exercicio 10









    }//fim da classe
}//fim do projeto



