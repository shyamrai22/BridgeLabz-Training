using System;

class EarthVolume {

	static void Main(string[] args) {
		double  radius = 6378; 
		double  kmVol = (4.0/3.0) * Math.PI * Math.Pow(radius,3);
		double  milesVol = (4.0/3.0) * Math.PI * Math.Pow(radius * 0.621371,3);
		Console.WriteLine($"The volume of earth in cubic kilometers is {kmVol} km and cubic miles is {milesVol} miles");
	
	}

}