using System;

class Program
{
	static void Main()
	{
		// Define the user's name
		string userName = "Matthew";

		// Greet the user based on whether a name is provided
		Console.WriteLine(!string.IsNullOrEmpty(userName) ? $"Hello, {userName}!" : "Hello!");

		// Define the user's question
		string userQuestion = "Will St.Mirren win a trophy this year?";
		Console.WriteLine(userQuestion);

		// Create a Random object to generate a random number
		Random random = new Random();
		int randomNumber = random.Next(0, 8); // Generate a random number between 0 and 7

		// Map the random number to a Magic 8 Ball response using a switch expression
		string eightBall = randomNumber switch
		{
			0 => "It is certain",
			1 => "It is decidedly so",
			2 => "Reply hazy try again",
			3 => "Cannot predict now",
			4 => "Do not count on it",
			5 => "My sources say no",
			6 => "Outlook not so good",
			7 => "Signs point to yes",
			_ => "Error" // Fallback case, though it shouldn't be reached
		};

		// Display the Magic 8 Ball's response
		Console.WriteLine($"Magic 8 ball says: {eightBall}");
	}
}