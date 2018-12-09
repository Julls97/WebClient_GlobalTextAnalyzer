using System;
using WebClient_GlobalTextAnalyzer.ServiceReference1;

namespace WebClient_GlobalTextAnalyzer {
	class Program {
		private static int DisplayMenu() {   
			Console.WriteLine("What are you want?");
			Console.WriteLine("1. makeCaps");
			Console.WriteLine("2. countOneWord");
			Console.WriteLine("3. countCharacters");
			Console.WriteLine("4. countWords");
			Console.WriteLine("5. Exit");
			var result = Console.ReadLine();
			return Convert.ToInt32(result);
		}
		
		static void Main(string[] args) {
			while (true) {
				var service = new ServiceReference1.HelloWorldClient();
				Console.Write("Input text: ");
				var text = Console.ReadLine();

				Console.Write("Input word: ");
				var word = Console.ReadLine();

				try {
					int userInput = 0;
					do {
						userInput = DisplayMenu();
						switch (userInput) {
							case 1: Console.WriteLine("Result of makeCaps: " + service.makeCaps(text)); break;
							case 2: Console.WriteLine("Result of countOneWord: " + service.countOneWord(text, word)); break;
							case 3: {
								Console.WriteLine("Result of countCharacters: ");
								var mpCharacters = service.countCharacters(text);
								foreach (pair t in mpCharacters)
									Console.WriteLine(t.x + "  " + t.y);
							} break;
							case 4: {
								Console.WriteLine("Result of countWords: ");
								var mpWords = service.countWords(text);
								foreach (pair t in mpWords)
									Console.WriteLine(t.x + "  " + t.y);
							} break;
							case 5: Environment.Exit(0); break;
							default: Console.WriteLine("Input error. Try again."); break;
						}

						Console.WriteLine("Enter anything");
						Console.Read();
					} while(userInput!=5);
				}
				catch (Exception) { Console.WriteLine("Server Error"); }
			}
		}
	}
}