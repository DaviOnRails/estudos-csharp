using System;


namespace aula1
{
  class Program
  {
    static void Main(string[] args)
    {
       var id = Guid.NewGuid();
       id.ToString();

       id = new Guid("");
       Console.WriteLine(id);
    }
  }
}