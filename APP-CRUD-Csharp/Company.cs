using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_CRUD_Csharp
{
	class Company
	{
		public string Name { get; set; }
		public int Month { get; set; }
		public double Money { get; set; }
		public List<Finance> Finances = new List<Finance>();

		public void AddFinance(Finance finance)
		{
			Finances.Add(finance);
		}
		public bool SearchName(string nameToSearch)
		{
			var financeInList = Finances.FirstOrDefault(n => n.Name.Equals(nameToSearch));
			if (financeInList == null)
			{
				return false;
			}
			return true;
		}
		public Finance SearchMonth(int monthToSearch)
		{
			var financeInList = Finances.FirstOrDefault(n => n.Month == monthToSearch);
			return financeInList;
		}
		public void PrintFinance()
		{
			Console.WriteLine("The Information Of Salary Added");
			Console.WriteLine();
			foreach (var finance in Finances)
			{
				Console.WriteLine($"-Name: {finance.Name}");
				Console.WriteLine($"-The Month: {finance.Month}");
				Console.WriteLine($"-The Salary: {finance.Money:f2} vnd");
				Console.WriteLine("******************");
			}
			double result = Finances.Sum(n => n.Money);
			Console.WriteLine($"The sum of Salary: {result:f2} vnd");
			Console.WriteLine("******************");
			if (!Finances.Any())
			{
				Console.WriteLine("Invalid result, Please Do Select 1");
				Console.WriteLine("*****************");
			}
		}
		public bool UpdateFinance(string nameToUpdate, int newMonth, double newMoney)
		{
			var financeInList = Finances.FirstOrDefault(n => n.Name.Equals(nameToUpdate));
			financeInList.Month = newMonth;
			financeInList.Money = newMoney;
			return true;
		}
		public bool DeleteFinanceByName(string nameToDelete)
		{
			var financeInList = Finances.FirstOrDefault(n => n.Name.Equals(nameToDelete));
			Finances.Remove(financeInList);
			return true;
		}
	}
}
