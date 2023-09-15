using System;
					
public class WeatherAdviser
{
	public static void Main()
	{
		Console.WriteLine("what is the temperature in C?");
		int temp = Convert.ToInt32(Console.ReadLine());
		
		
		if(temp >= 20)
		{
			Console.WriteLine("enjoy the nice weather!");
		}else if( temp < 20 && temp >= 10 ){
			Console.WriteLine("maybe wear a light jacket");
		}else if( temp < 10 ){
			Console.WriteLine("wear some really warm clothes!");
		}
		
	}
}