using System;
using System.Text;

class ReverseString
{
	static void Main(string[] args) {
		Console.Write("Enter a String: ");
		string s = Console.ReadLine();
		
		StringBuilder sb = new StringBuilder();
		
		for(int i = s.Length - 1; i >= 0; i--) {
			sb.Append(s[i]);
		}
		
		s = sb.ToString();
		Console.WriteLine(s);
		
	}
}