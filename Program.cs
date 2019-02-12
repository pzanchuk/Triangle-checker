using System;


namespace Triangle {

  public class Program{
    public static void Main(){

      Console.WriteLine("====================================");
      Console.WriteLine("Please enter the length of side a: ");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the length of side b: ");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the length of side c: ");
      int c = int.Parse(Console.ReadLine());

      MyTriangle triangle = new MyTriangle(a, b, c);
      triangle.CheckTriangle();
      Console.WriteLine("Press Q to quit");
      string input = Console.ReadLine();

      do{
        Main();
      }while(input != "Q");

    }
  }
}
