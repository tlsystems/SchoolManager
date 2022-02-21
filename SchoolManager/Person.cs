using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager
{
	class Person
	{
		public string FirstName;
		public string LastName;
		public DateTime DOB;

		public Person(string fName, string lName, string dob)
		{
			FirstName = fName;
			LastName = lName;
			DateTime.TryParse(dob, out DOB);
		}

		public Person(string fName, string lName, DateTime dob)
		{
			FirstName = fName;
			LastName = lName;
			DOB = dob;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} {DOB:MMM dd, yyyy}";
		}
	}
}
