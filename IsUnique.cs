using System;
using System.Text;
					
public class Program
{
	public static void Main()
	{
		 string input = "SAA";
        bool isUnique = IsUnique(input);
		Console.WriteLine(isUnique);
	}
	
	public static bool IsUnique(string input)
    {
        bool[] array = new bool[128];
        foreach (char b in input.ToCharArray())
        {
			if(array[b])
            	return false;
			else
				array[b] = true;
        }
		return true;
    }
}
