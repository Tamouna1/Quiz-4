using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{ 

	public class department
	{

		public string name;
		public int maxEmployees;

		public department(string name, int maxEmployees)
		{
			this.name = name;
			this.maxEmployees = 
				maxEmployees;
		}
	}
}
