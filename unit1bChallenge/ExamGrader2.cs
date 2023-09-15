using System;
					
public class ExamGrader2
{
	public static void Main()
	{
		Console.WriteLine("What is your exam score as a percentage?");
		int temp = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("What is your favorite subject in school?");
		string subject = Console.ReadLine();
		
		
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
		
		
		switch(subject)
		{
			case "math":
				Console.WriteLine("you like math? ok bro, you do you");
				break;
			case "english":
				Console.WriteLine("you a book worm i take it?");
				break;
			case "PE":
				Console.WriteLine("get those GAINS");
				break;
			case "astronomy":
				Console.WriteLine("space is pretty cool");
				break;
			default:
				Console.WriteLine("the subject you entered wasnt on my list :(");
				break;
				
		}
	}
}