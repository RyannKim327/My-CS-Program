using System;

public class names{
	public string full{
		get;
		set;
	}
}

public class Program2{ // change the Program2 to Program
	static names n;
	static void Main(String[] a){
		n = new names();
		Console.Write("Enter your full name: ");
		n.full = Console.ReadLine();
		act();
	}
	static void act(){
		Console.WriteLine("Hello " + n.full);
	}
}
