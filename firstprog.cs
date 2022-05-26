using System;

public class names{
	public string full{
		get;
		set;
	}
}

public class Program{
	static names n;
	static void Main(String[] a){
		n = new names();
		n.full = "Ryann Kim Sesgundo";
		act();
	}
	static void act(){
		Console.WriteLine(n.full);
	}
}
