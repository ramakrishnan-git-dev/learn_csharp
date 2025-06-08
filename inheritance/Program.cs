/*Title       : Inheritance
  Author      : Ramakrishnan N
  Created at  : 30/09/2022
  Reviewed by : 
  Reviewed at :*/
using System;
namespace ConsoleApplication {
class SuperClass {
	public void executeBaseClass()
	{
		Console.WriteLine("Base class executed");
	}
}
class SubClass : SuperClass {
	public void executeDerivedClass()
	{
		Console.WriteLine("Derived class executed");
	}
}
class Inheritance {
	static void Main(string[] args)
	{
		SubClass subClass = new SubClass();
		subClass.executeDerivedClass();
        subClass.executeBaseClass();
	}
}
}
