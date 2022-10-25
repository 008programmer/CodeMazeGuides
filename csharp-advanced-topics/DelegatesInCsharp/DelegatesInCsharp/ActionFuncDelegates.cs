using System;

namespace DelegatesInCsharp
{
	public class Program
	{
		delegate string FormatNameDel(string firstName, string surName);

		private static void Main(string[] args)
		{
			bool showSurNameFirst = true;

			FormatNameDel formatingNameFn = showSurNameFirst
				? SurNameFirst
				: FirstNameFirst;


			string name = formatingNameFn("Will", "Smith");

			Console.WriteLine(name);

			Console.ReadLine();
		}

		public static string FirstNameFirst(string firstName, string surName)
		{
			return $"{firstName} {surName}";
		}

		public static string SurNameFirst(string firstName, string surName)
		{
			return $"{surName} {firstName}";
		}

		public static void ShowUser()
		{
			Console.WriteLine("This method will show User");
		}

		public static void ShowAuthors()
		{
			Console.WriteLine("This method will show Authors");
		}

	}
}