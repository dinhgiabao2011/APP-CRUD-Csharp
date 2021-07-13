using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_CRUD_Csharp
{
	class UI
	{
		public static void Title()
		{
			Console.WriteLine("******************************************************");
			Console.WriteLine("** Welcom to The program management finance Company **");
			Console.WriteLine("******************************************************");
		}
		public static void Menu()
		{
			Console.WriteLine();
			Console.WriteLine("1. Enter the information of the next person");
			Console.WriteLine("2. Print the information of the person added");
			Console.WriteLine("3. Update the information of the person added");
			Console.WriteLine("4. Delete the information of the person added");
			Console.WriteLine("5. Exit The Program");
			Console.WriteLine();
		}
		public static string Command()
		{
			Console.WriteLine("Please enter Command: ");
			return Console.ReadLine();
		}
		public static string EnterName()
		{
			Console.Write("* Enter Name: ");
			return Console.ReadLine();
		}
		public static double EnterMoney()
		{
			Console.Write("* Enter Salary: ");
			return double.Parse(Console.ReadLine());
		}
		public static int EnterMonth()
		{
			Console.Write("* Enter month: ");
			return int.Parse(Console.ReadLine());
		}
		public static string TypeExitToFinish()
		{
			Console.WriteLine("Type Exit to Finish Option!!!");
			return Console.ReadLine();
		}
		public static void EnterNameAgain()
		{
			Console.WriteLine("This name already exist!!!");
			Console.WriteLine("Please enter Name again!!!");
		}
		public static void UpdateSuccessful()
		{
			Console.WriteLine("Update successfully!!!");
		}
		public static void UpdateFailse()
		{
			Console.WriteLine("Update Failse!!!");
			Console.WriteLine("Please enter Name Again!!!");
		}
		public static void DeleteFailse()
		{
			Console.WriteLine("Delete Failse!!!");
			Console.WriteLine("Please enter Name Again!!!");

		}
		public static void DeleteSuccessful()
		{
			Console.WriteLine("Delete successfully!!!");
		}
		public static void InvalidCommand()
		{
			Console.WriteLine("There is No select!");
		}
		public static void EnterMonthAgain()
		{
			Console.WriteLine("****************************************************");
			Console.WriteLine("** It is a negative number or beyond number 12!!! **");
			Console.WriteLine("*********** Please enter month a again.*************");
			Console.WriteLine("****************************************************");
		}
	}
}
