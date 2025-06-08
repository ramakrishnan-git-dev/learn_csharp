/*Title       : Runtime Polymorphism
  Author      : Ramakrishnan N
  Created at  : 30/09/2022
  Reviewed by : 
  Reviewed at :*/
using System;
public class Addition {
    public int addNumbers(int a,int b){
        return a+b;
    }
}
class Subtraction : Addition{
    public int subNumbers(int x,int y){
        return x-y;
    }
}
class RuntimePolymorphism {
	static public void Main()
	{
		Addition addition = new Addition();
        Subtraction subtraction = new Subtraction();
	    int m=5;
        int n=2;
		Console.WriteLine("Add: " + addition.addNumbers(m,n));
		Console.WriteLine("Sub: " + subtraction.subNumbers(m,n));
	}
}