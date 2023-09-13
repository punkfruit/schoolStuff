using System;
					
public class TemperatureCheck
{
	public static void Main()
	{
		Console.WriteLine("Enter the current temperature in C (commie units)");
		int temp = Convert.ToInt32(Console.ReadLine());
		if(temp >= 30)
		{
			Console.WriteLine("Drink some water and dont stay outside too long!!!");
		}
		
		if(temp < 30)
		{
			Console.WriteLine("Enjoy the good weather!");
		}

        Console.ReadLine();
	}
}