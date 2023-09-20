using System;
					
public class NumberPyramid
{
	public void Main()
	{
        Console.WriteLine("Enter the number of rows for the pyramid: ");
        int numRows;

        while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer: ");
        }

        for (int i = 1; i <= numRows; i++)
        {
            int spaces = numRows - i;

            for (int s = 1; s <= spaces; s++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
		}
	}
}