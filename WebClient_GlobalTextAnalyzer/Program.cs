using System;
using WebClient_GlobalTextAnalyzer.ServiceReference1;

namespace WebClient_GlobalTextAnalyzer {
	class Program {
		private static int DisplayMenu() {   
			Console.WriteLine("What are you want?");
			Console.WriteLine();
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
				Console.WriteLine();

				try {
					int userInput = 0;
					do {
						userInput = DisplayMenu();
						switch (userInput) {
							case 1: Console.WriteLine("makeCaps: " + service.makeCaps(text)); break;
							case 2: Console.WriteLine("countOneWord: " + service.countOneWord(text, word)); break;
							case 3: {
								Console.WriteLine("countCharacters: ");
								var mpCharacters = service.countCharacters(text);
								foreach (pair t in mpCharacters)
									Console.WriteLine(t.x + "  " + t.y);
							} break;
							case 4: {
								Console.WriteLine("countWords: ");
								var mpWords = service.countWords(text);
								foreach (pair t in mpWords)
									Console.WriteLine(t.x + "  " + t.y);
							} break;
							default: Console.WriteLine("Error. Try again."); break;
						}
					} while(userInput!=5);
				}
				catch (Exception) { Console.WriteLine("Server Error"); }

//				Console.WriteLine("Exit? y/n");
//				var str = Console.ReadLine();
//				if (str == "y") Environment.Exit(0);
			}
		}
	}
}

//using System;
//
//namespace WebClient_GlobalTextAnalyzer {
//	class Program {
//		static void Main(string[] args) {
//			while (true) {
//				var service = new ServiceReference1.HelloWorldClient();
//				Console.Write("Input text: ");
//				var text = Console.ReadLine();
//
//				Console.Write("Input word: ");
//				var word = Console.ReadLine();
//
//				try {
//					Console.WriteLine("makeCaps: " + service.makeCaps(text));
//
//					Console.WriteLine("countOneWord: " + service.countOneWord(text, word));
//
//					Console.WriteLine("countWords: ");
//					var mpWords = service.countWords(text);
//					for (int i = 0; i < mpWords.Length; i++)
//						Console.WriteLine("\"" + mpWords[i].x + "\" - " + mpWords[i].y);
//					
//					Console.WriteLine("countCharacters: ");
//					var mpCharacters = service.countCharacters(text);
//					for (int i = 0; i < mpCharacters.Length; i++)
//						Console.WriteLine(mpCharacters[i].x + "  " + mpCharacters[i].y);
//				}
//				catch (Exception) { Console.WriteLine("Server Error"); }
//
//				Console.WriteLine("Exit? y/n");
//				var str = Console.ReadLine();
//				if (str == "y") Environment.Exit(0);
//			}
//		}
//	}
//}