using System;
using System.Threading;

namespace anagram
{
   class Program
   {
      
      static void Main(string[] args)
      {
         string wordOne;
         string wordTwo;

         Console.WriteLine("Bienvenido!!!");
         Console.WriteLine("Esto es un ejercicio para determinar si una palabra es anagrama de otra.");
         
         Console.WriteLine("Ingrese la primer palabra (es para evaluar si es palabra anagram)");
         wordOne = Console.ReadLine();
         
         Console.WriteLine("Ingrese la segunda palabra");
         wordTwo = Console.ReadLine();

         //First validation. Lenghts words
         if(wordOne.Length != wordTwo.Length)
         {
            Console.WriteLine("Las palabras no son anagrama");
            Thread.Sleep(1000);
            return;
         }

         if(AnagramRemove(ref wordOne, ref wordTwo))
         {
            Console.WriteLine("Las palabras son anagramas");
         }
         else
         {
            Console.WriteLine("Las palabras no son anagrama");
         }
         Thread.Sleep(1000);
      }

      static private bool AnagramRemove(ref string word1, ref string word2)
      {
         for (int i = 0; i < word1.Length; i++)
         {
            int pos = word2.IndexOf(word1[i]);
            if (pos > -1) word2 = word2.Remove(pos, 1);
            else break;
         }

         return word2 == "";
      }
   }
}
