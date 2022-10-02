using System;

namespace Calculator
{
  class Program

  {
    static void Main(string[] args)
    {
      Soma();
      subtracao();
    }

    static void Soma()
    {
      //primeiro valor
      Console.Clear();
      Console.WriteLine("primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      //segundo valor
      Console.WriteLine("segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine(" ");
      float resultado = v1 + v2;
      Console.WriteLine("O resultado da soma é:" + resultado);

    }

    static void subtracao()
    {
      //primeiro valor
      Console.Clear();

      Console.WriteLine("primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());
      
      //segundo valor
      Console.WriteLine("segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine(" ");
 
      float resultado = v1-v2;
      Console.WriteLine("O resultado da subtração é: " + resultado);
      Console.ReadKey();
    }
    
  }
}