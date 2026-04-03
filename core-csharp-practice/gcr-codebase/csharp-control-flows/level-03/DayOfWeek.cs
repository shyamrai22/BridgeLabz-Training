using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
            return;
        }

        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        int year = int.Parse(args[2]);

    
        int yo = year - (14 - month) / 12;
		
        int x = yo + yo / 4 - yo / 100 + yo / 400;
        
		int mo = month + 12 * ((14 - month) / 12) - 2;
        
		int d0 = (day + x + (31 * mo) / 12) % 7;

        Console.WriteLine(d0);
    
	}
}
