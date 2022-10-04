using System;
using System.Threading;

namespace cronometro
{
    class program{
        static void Main(string [] args){
                Menu();
                Start(6);
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S - segundos => 10s = 10 segundos");
            Console.WriteLine("M - minuto => 1m = 1 minuto");
            Console.WriteLine("0 - sair");
            Console.WriteLine("Quanto tempo você deseja contar");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1));

            int multiplier = 1;

            if( type == 'm'){
                multiplier = 60;
            }

            if(time == 0)
                System.Environment.Exit(0);
            

            PreStart(time * multiplier);
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("One");
            Thread.Sleep(1000);

            Console.WriteLine("Two");
            Thread.Sleep(1000);

            Console.WriteLine("Tree");
            Thread.Sleep(1000);
            
            Console.WriteLine("Golgolgol!");
            Thread.Sleep(1000);
            Thread.Sleep(1500);

            Start(time);
        }
        static void Start(int time){
          
           int CurrentTime = 0;

           while(CurrentTime != time){

                 Console.Clear();
                 CurrentTime ++;
                 Console.WriteLine(CurrentTime);
                 Thread.Sleep(1000);
           }
           Console.Clear();
           Console.WriteLine("Cronometro finalizado");
           Thread.Sleep(2500);

           Menu();
        }

    }
}