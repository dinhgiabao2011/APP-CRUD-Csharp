using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_CRUD_Csharp
{
	class Finance
	{
		public string Name { get; set; }

		public int Month { get; set; }

		public double Money { get; set; }

		public Finance(string name, int month, double money)
		{
			Name = name;
			Month = month;
			Money = money;
		}
	}
}
