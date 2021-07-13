using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_CRUD_Csharp
{
	class Program
	{
		static void Main(string[] args)
		{
			UI.Title();
			UI.Menu();
			var company = new Company();
			string menuOption = MenuOptions.Empty;
			{
				menuOption = UI.Command();

				switch (menuOption)
				{
					case MenuOptions.EnterInformation:
						do
						{
							string nameToEnter = UI.EnterName();
							while (company.SearchName(nameToEnter))
							{
								UI.EnterNameAgain();
								nameToEnter = UI.EnterName();
							}
							int monthToEnter = UI.EnterMonth();
							company.SearchMonth(monthToEnter);
							while (monthToEnter < 0 || monthToEnter > 12)
							{
								UI.EnterMonthAgain();
								monthToEnter = UI.EnterMonth();
							}
							company.AddFinance(new Finance(nameToEnter, monthToEnter, UI.EnterMoney()));
							UI.Menu();
						} while (UI.TypeExitToFinish() != "Exit");
						break;
					case MenuOptions.PrintInformation:
						company.PrintFinance();
						UI.Menu();
						break;
					case MenuOptions.UpdateInformation:
						do
						{
							string nameToUpdate = UI.EnterName();
							while (!company.SearchName(nameToUpdate))
							{
								UI.UpdateFailse();
								nameToUpdate = UI.EnterName();
							}
							int monthToEnter = UI.EnterMonth();
							company.SearchMonth(monthToEnter);
							while (monthToEnter < 0 || monthToEnter > 12)
							{
								UI.EnterMonthAgain();
								monthToEnter = UI.EnterMonth();
							}
							company.UpdateFinance(nameToUpdate, monthToEnter, UI.EnterMoney());
							UI.UpdateSuccessful();
							UI.Menu();
						} while (UI.TypeExitToFinish() != "Exit");
						break;
					case MenuOptions.DeleteInformation:
						do
						{
							string nameToDelete = UI.EnterName();
							while (!company.SearchName(nameToDelete))
							{
								UI.DeleteFailse();
								nameToDelete = UI.EnterName();
							}
							company.DeleteFinanceByName(nameToDelete);
							UI.DeleteSuccessful();
							UI.Menu();
						} while (UI.TypeExitToFinish() != "Exit");
						break;
					case MenuOptions.Exit:
						return;
					default:
						UI.InvalidCommand();
						break;
				}
			} while (menuOption != MenuOptions.Exit) ;
		}
	}
}
