using System;

public class MyClass
{

    public Food food1;
    public void Main(string[] args)
    {
        //this is a comment
        //lets make some variables
        food1 = new Food();

        food1.name = "steak";
        food1.healthRecovery = 50;
        food1.isCookable = true;

        int health = 100;
        double floatAlt = 4.20D;
		
        string name = "keanu";
        int age;

        age = OtherMethod(food1, health);

        Console.WriteLine("wow look its " + name + " who is " + age + " years old!");

       
    }    

    public int OtherMethod(Food numb, int numb2)
    {
        //adds food recovery to given number
        return numb.healthRecovery + numb2;

    }

}

public class Food {
    public string name;
    public bool isCookable;
    public int healthRecovery;
}