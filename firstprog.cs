using System;

public class my_name{
	public string full{
		get;
		set;
	}
}

public class Program1{ // change the Program1 to Program
	static my_name n;
	static void Main(String[] a){
		n = new my_name();
		n.full = "Ryann Kim Sesgundo";
		act();
	}
	static void act(){
		Console.WriteLine(n.full);
	}
}
