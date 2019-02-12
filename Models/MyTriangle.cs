using System;

namespace Triangle{

  class MyTriangle{

    private int SideA;
    private int SideB ;
    private int SideC;

    public MyTriangle(int a, int b, int c){
      SideA = a;
      SideB = b;
      SideC = c;
    }
    public int GetSideA(){
      return SideA;
    }
    public int GetSideB(){
      return SideB;
    }
    public int GetSideC(){
      return SideC;
    }
    public void CheckTriangle(){
      if(SideA + SideB < SideC || SideB + SideC < SideA || SideC+ SideA < SideB){
        Console.WriteLine("Not a triangle");
      }else{
        if(SideA == SideB && SideA == SideC){
          Console.WriteLine("Your triangle is Equilateral");
        }else if(SideA != SideB && SideB != SideC && SideC != SideA){
          Console.WriteLine("Your triangle is Scalene");
        }else{
          Console.WriteLine("Your triangle is Isosceles");
        }
      }
    }
  }
}
