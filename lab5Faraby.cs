using System;
					
public class Program
{
	public static void Main()
	{
		int x = 0;
		string realPass = "password123";
		string pass;
		
			
			for(int i = 0; i < 3; i++){
				Console.WriteLine("Your password: ");
				pass = Console.ReadLine();
				if (pass == realPass ) {
					Console.WriteLine("Welcome, User");
					break;
				}
				x++;
				if(x>2){
					Console.WriteLine("Sorry, you're done!");
					break;
				}
				Console.WriteLine("Incorrect password. You have only " + (3-x) + " tries");	
			}
	}
}