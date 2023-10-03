using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Ritola_Array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Number of times to run the loop
			RunLoops(1);
		}
		public static void RunLoops(int loops)
		{
			for (int i = 0; i < loops; i++)
			{
				Stopwatch swLoop = new Stopwatch();
				swLoop.Start();
				char[] randomChars = GenerateRandomUniqueChars(50);
				string characters = string.Join(" ", randomChars);
				string time = "Loop time: " + swLoop.Elapsed.ToString();
				swLoop.Stop();
				Console.WriteLine(characters);
				Console.WriteLine(time);
			}
			
		}

		static char[] GenerateRandomUniqueChars(int length)
		{
			char[] chars = new char[length];
			Random random = new Random();

			for (int i = 0; i < length; i++)
			{
				char randomChar;
				do
				{
					// Generate a random ASCII value for either lowercase or uppercase letter
					int asciiValue = random.Next(2) == 0 ? random.Next(65, 91) : random.Next(97, 123);
					randomChar = (char)asciiValue;
				} while (chars.Contains(randomChar)); // Check for uniqueness
				chars[i] = randomChar;
			}
			return chars;
		}
	}
}