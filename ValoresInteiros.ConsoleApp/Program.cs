using System.Runtime.InteropServices;

namespace ValoresInteiros.ConsoleApp
{
    internal class Program
    {
        static int[] valoresInteiros = new int[10];

        static void Main(string[] args)
        {

            Console.WriteLine("Informe dez valores inteiros: ");
            for (int i = 0; i < 10; i++) 
            {
                Console.Write($"Valor {i}: ");
                valoresInteiros[i] = int.Parse(Console.ReadLine());    
            }   

            int maiorValor = EncontrarMaiorValor(valoresInteiros); 
            Console.WriteLine($"O maior valor é: {maiorValor}");

            int menorValor = EncontrarMenorValor(valoresInteiros);
            Console.WriteLine($"O menor valor é: {menorValor}");

            double valorMedio = EncontrarValorMedio(valoresInteiros);
            Console.WriteLine($"o valor médio é: {valorMedio}");

            int tresMaioresValores = EncontrarTresMaioresValores(valoresInteiros);

            Console.Write($"Os valores negativos são: ");
            EncontrarValoresNegativos(valoresInteiros);
            Console.WriteLine("");

            Console.Write($"Os valores são: ");
            MostrarValores(valoresInteiros);

            Console.WriteLine();
            RemoverValor(valoresInteiros);  


            Console.WriteLine();
            Console.WriteLine();
        }
 
        static int EncontrarMaiorValor(int[] valoresInteiros) { 

        int maiorValor = valoresInteiros[0];

            for (int i = 0; i < valoresInteiros.Length; i++)
            {
                if (valoresInteiros[i] > maiorValor)
                {
                    maiorValor = valoresInteiros[i];
                }
            }
            return maiorValor;

        }
        
        static int EncontrarMenorValor(int[] valoresInteiros)
        {

            int menorValor = valoresInteiros[0];

            for (int i = 0; i < valoresInteiros.Length; i++)
            {
                if (valoresInteiros[i] < menorValor)
                {
                    menorValor = valoresInteiros[i];
                }
            }
            return menorValor;
        }

        static double EncontrarValorMedio(int[] valoresInteiros)
        {

            double somaValores = 0;

            for (int i = 0; i < valoresInteiros.Length; i++)
            {
                somaValores += valoresInteiros[i];  
            }
            return somaValores / valoresInteiros.Length;
        }

        static int EncontrarTresMaioresValores(int[] valoresInteiros)
        {

            int tresMaioresValores = valoresInteiros[0];

            Array.Sort(valoresInteiros);

            Console.WriteLine($"Três maiores valores: {valoresInteiros[7]}, {valoresInteiros[8]}, {valoresInteiros[9]}  ");

            return tresMaioresValores;
        }

        static int EncontrarValoresNegativos(int[] valoresInteiros)
        {

            int valoresNegativos = valoresInteiros[0];

            for (int i = 0; i < valoresInteiros.Length; i++)
            {
                if (valoresInteiros[i] < 0)
                {
                    Console.Write($"{valoresInteiros [i]} ");
                }
            }
            return valoresNegativos;
        }

        static void MostrarValores(int[] valoresInteiros)
        {
            for(int i = 0; i < valoresInteiros.Length; i++)
            {
                Console.Write($"{valoresInteiros[i]}  ");
            }
        }

        static void RemoverValor(int[] valoresInteiros)
        {
            Console.Write("Digite um valor para remover: ");
            int valorRemovido = int.Parse(Console.ReadLine());  

            for (int i = 0; i < valoresInteiros.Length; i++)
            {
                if (valorRemovido == valoresInteiros[i])
                {
                    valoresInteiros[i] = 0;
                }
            }
            for (int i = 0; i < valoresInteiros.Length; i++)
            {
                Console.Write($"{valoresInteiros[i]}  ");
            }
        }
    }
}

