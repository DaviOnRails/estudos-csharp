using System;

namespace Editor{

class Program {
    static void Main (string[] args){
            Menu();
            Editar();
    }

   static void Menu(){
    
    Console.Clear();
    Console.WritLine("o que você deseja fazer");
    Console.WritLine("1 - Abrir arquivo");
    Console.WritLine("2 - Criar novo arqivo");
    Console.WritLine("0 -  Sair");
    short option = short.Parse(Console.ReadLine());

    switch(option){
        case 0:System.Environment.Exit(0);break;
        case 1:Abrir(); break;
        case 2:Editar(); break;
        default: Menu(); break;
    }
   }
   static void Abrir(){

    }
   static void Editar(){
           Console.Clear();
           Console.WriteLine("digite seu texto (esc para sair");
           Console.WriteLine("----------------");
           string text = "";
                 
            do{
            text += Console.ReadLine();
            text += Environment.NewLine;
            }     
           while(console.ReadKey().key != ConsoleKey.Escape);
                    
           Console.Write(text);
    }
   
}
}