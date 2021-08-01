using System;
using System.Collections.Generic;

class SLL {

	// Main Method
	static public void Main()
	{

		LinkedList<int> LinkedList = new LinkedList<int>();

        

		LinkedList.AddLast(1);
		LinkedList.AddLast(2);
		LinkedList.AddLast(3);
		LinkedList.AddLast(4);
		LinkedList.AddLast(5);
		LinkedList.AddLast(6);

		Console.WriteLine("List: ");

		
		foreach(int num in LinkedList)
		{
			Console.WriteLine(num);
		}
	}
}