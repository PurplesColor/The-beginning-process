using System;

class Program {
    static void Main(string[] args) {

       int a = Int32.Parse (Console.ReadLine());
      if (a < 13){
        Console.WriteLine("kid");
      }
      if (a >= 13 && a < 18) {
        
        Console.WriteLine("Teenager");
      }
      if (a >= 18) {
            Console.WriteLine("adult");
          }
    }
}
