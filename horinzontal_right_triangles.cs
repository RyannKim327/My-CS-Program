using System;

class Program{
	public static void Main(string[] args){
		int height = 5;
		int width = 5;
		Console.Write("Enter number of duplication: ");
		int duplication = int.Parse(Console.ReadLine());
		Console.WriteLine();
		string result = "";
		for(int h = 1; h <= height; h++){
			for(int d = 1; d <= duplication; d++){
				int w = 1;
				while(w <= h){
					result += "* ";
					w++;
				}
				for(;w <= width; w++){
					result += "  ";
				}
			}
			result += "\n";
		}
		Console.WriteLine(result);
	}
}