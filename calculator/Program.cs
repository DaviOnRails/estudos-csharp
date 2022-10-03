using System;

namespace Calculator
{
  class Program

  {
    static void Main(string[] args)
    {
      Menu();
      Soma();
      Subtracao();
      Divisao();
      Multiplicacao();
    }
    static void Menu(){
      Console.Clear();

      Console.WriteLine("O que deseja fazer");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - sair");

      Console.WriteLine("-------------------");
      Console.WriteLine("Selecione uma opção: ");
      short res = short.Parse(Console.ReadLine());

      switch(res){
          case 1: Soma(); break;
          case 2: Subtracao(); break;
          case 3: Divisao(); break;
          case 4: Multiplicacao(); break;
          case 5: System.Environment.Exit(0); break;
          default : Menu(); break;
      }
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
          Console.ReadKey();
          Menu();
    }

    static void Subtracao()
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
      Menu();
    }

    static void Divisao(){
      //primeiro valor
       Console.Clear();
       Console.WriteLine("primeiro valor é: ");
       float v1 = float.Parse(Console.ReadLine());
      
      //segundo valor     
      Console.WriteLine("segundo valor é: ");
      float v2 = float.Parse(Console.ReadLine());
      
      float resultado = v1 / v2 ;
      Console.WriteLine(" ");
      Console.WriteLine( "O resultado da divisão e: " + resultado);
      Console.ReadKey();
      Menu();

    }

    static void Multiplicacao(){
     //primeiro valor
       Console.Clear();
       Console.WriteLine("primeiro valor é: ");
       float v1 = float.Parse(Console.ReadLine());
      
     //segundo valor     
      Console.WriteLine("segundo valor é: ");
      float v2 = float.Parse(Console.ReadLine());
      
      float resultado = v1 * v2 ;
      Console.WriteLine(" ");
      Console.WriteLine( "O resultado da multiplicação é: " + resultado);
      Console.ReadKey();
          Menu();
    }

  }
}