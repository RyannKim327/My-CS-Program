using System;

class Program3{ // change the Program3 to Program
	static void Main(String[] args){
		string a, b;
		Console.WriteLine("Multiplication Table");
		Console.Write("Enter number (Vertical): ");
		a = Console.ReadLine();
		Console.Write("Enter number (Horizontal): ");
		b = Console.ReadLine();
		int x = int.Parse(a);
		int y = int.Parse(b);
		for(int i = 1; i <= x; i++){
			for(int j = 1; j <= y; j++){
				Console.Write((i * j) + " ");
			}
			Console.WriteLine();
		}
	}
}
