using System;
					
public class ExamGrader
{
	public static void Main()
	{
		Console.WriteLine("What is your exam score as a percentage?");
		int temp = Convert.ToInt32(Console.ReadLine());
		
		
		if(temp >= 90)
		{
			Console.WriteLine("You have an A!");
		}else if( temp < 90 && temp >= 80 ){
			Console.WriteLine("You have a B!");
		}else if( temp < 80 && temp >= 70 ){
			Console.WriteLine("You have a C!");
		}else if( temp < 70 && temp >= 60 ){
			Console.WriteLine("You have a D!");
		}else if( temp < 60 ){
			Console.WriteLine("You have an F!");
		}else {
			Console.WriteLine("Error");
		}
	}
}