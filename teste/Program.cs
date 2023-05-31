using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //só consegui fazer o 1
            //exercicio1()
            //int[] vet2;
            //float media = 0;
            //Console.WriteLine("entre com o tamanho");
            //int T = int.Parse(Console.ReadLine());
            //vet2 = new int[T];
            //Random rand = new Random();
            //for (int i = 0; i < T; i++)
            //{
            //    vet2[i] = rand.Next(10, 50);
            //    media = media + vet2[i];
            //}
            //for (int i = 0; i < T; i++)
            //{
            //    Console.WriteLine("digite o valor da posição [{0}] = {1}", i, vet2[i]);
            //}
            //Console.WriteLine(media / (float)T);
            //Console.ReadKey();


            int[] vet1;
            int r, soma = 0, somas = 0;
            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet1 = new int[t];
            Random rando = new Random();
            for (int i = 0, i < t; i++)
            {
                vet1[i] = rando.Next(10, 50); 
            }




            int op;
            Console.WriteLine("MENU");
            Console.WriteLine("ex1");
            Console.WriteLine("ex2");

            op = int.Parse(Console.WriteLine);



        }
    }
}
