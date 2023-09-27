using System;
					
public class FavoriteFood
{
	public static void Main()
	{
        string[] favoriteFoods = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Please enter your favorite food #" + (i + 1));
            favoriteFoods[i] = Console.ReadLine();
        }

        for (int i = 0; i < favoriteFoods.Length; i++)
        {
            Console.WriteLine("I love " + favoriteFoods[i] + "!");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
	}
}