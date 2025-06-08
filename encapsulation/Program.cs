/*Title       : Encapsulation
  Author      : Ramakrishnan N
  Created at  : 30/09/2022
  Reviewed by : 
  Reviewed at :*/
using System;
public class Encapsulation {
	private int a;
	public int num
	{
		get
		{
			return a;	
		}
		set
		{
			a = value;
		}	
	}	
}
class Execution{
	static public void Main()
	{
		Encapsulation encapsulation = new Encapsulation();
		encapsulation.num = 10;
		Console.WriteLine(encapsulation.num);
	}
}