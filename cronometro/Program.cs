using System;
using System.Threading;

namespace cronometro
{
    class program{
        static void main(string [] args){
                Start();
        }

        static void Start(){
           int time = 10;
           int currentTime = 10;


           while(currentTime != time){
                 Console.Clear();
                 currentTime ++;
                 Console.WriteLine(currentTime);
                 Thread.Sleep(1000);
           }
        }

    }
}