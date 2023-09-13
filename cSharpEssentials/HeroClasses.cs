//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;

    public Hero heroFour;
    //hero 3 is missing, heros 1 2 and 4 are going to look for them
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
        heroFour = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
        heroOne.name = "Jeff";
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
        heroTwo.name = "Mark";

        heroFour.health = 420;
        heroFour.powerLevel = 69;
        heroFour.name = "Elon";
		
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
        Console.WriteLine(heroOne.name);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
        Console.WriteLine(heroTwo.name);

        Console.WriteLine(heroFour.health);
		Console.WriteLine(heroFour.powerLevel);
        Console.WriteLine(heroFour.name);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
    public string name;
}