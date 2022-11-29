using System;

namespace EditoHtml{
      public static class Menu{
        public static void Show(){
           Console.Clear();
           Console.BackgroundColor = ConsoleColor.Blue;
           Console.ForegroundColor = ConsoleColor.Black;

           DrawScreen();
           WriteOptions();
        }
         
    public static void DrawScreen(){
           Console.Write("+");
           for(int i = 0; i <= 30; i++){
            Console.Write("-");
           }
                 
        }

    public static void WriteOptions(){
           //Console.SetCursorPosition(3, 2);
           //Console.WriteLine("editor");
    }

      }

}