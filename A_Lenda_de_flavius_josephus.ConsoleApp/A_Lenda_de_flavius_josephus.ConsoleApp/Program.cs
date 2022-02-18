using System;

namespace A_Lenda_de_flavius_josephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite a quantidade de prisioneiros");
             int n = System.Convert.ToInt32(Console.ReadLine());

            int[] qtpessoas = new int[n];
          
          //atribuindo os valores para o vetor
            for (int i = 0; i < qtpessoas.Length; i++)
            {
               qtpessoas[i] = i+1;

            }

            Console.WriteLine("Digite o número de saltos que irá ocorrer a execução:");
             int k = System.Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a quantidade de casos de testes que irá ocorrer:(1 ≤ NC ≤ 30 ) ");
             int nc = System.Convert.ToInt32(Console.ReadLine());

            for (int j=0;j<nc;j++) {
                for (int i = 0; i < qtpessoas.Length; i = i + k)
                {

                    Console.WriteLine("Caso " + (i+1) + ":" + qtpessoas[i]);
                    qtpessoas[i] = qtpessoas[i] - qtpessoas[i];

                }
            }


    
            Console.WriteLine("Número dos sobreviventes:");
            //resultado
            for (int i = 0; i < qtpessoas.Length; i++)
            {
                if (qtpessoas[i] == 0)
                {

                }
                else
                {

                    Console.WriteLine("Sobrevivente " + i + ": " + qtpessoas[i]);
                }
            }
    
        }
    }
}
