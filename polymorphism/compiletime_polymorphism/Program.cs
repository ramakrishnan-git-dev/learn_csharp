/*Title       : Compiletime Polymorphism
  Author      : Ramakrishnan N
  Created at  : 30/09/2022
  Reviewed by : 
  Reviewed at :*/
using System;
class CompiletimePolymorphism {
	static public void Main()
	{
	    int m=5, n=2;
        double c=12.5, d=9.3;
		Console.WriteLine("Integer: " + addNumbers(m,n));
		Console.WriteLine("Decimal: " + addNumbers(c,d));
	}
    public static int addNumbers(int a,int b){
        return a+b;
    }
    public static double addNumbers(double a,double b){
        return a+b;
    }
}