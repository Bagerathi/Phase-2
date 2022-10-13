using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnessLogicLayerLib
{
    public class Employee_BAL
    {
		private int _empID;

		public int EmployeeID
		{
			get { return _empID; }
			set { _empID = value; } //empid  is readonly prop, so no sitter , empid has identity=true
		}


		private string _lname;   //20

		public string LastName
		{
			get { return _lname; }
			set { _lname = value; }
		}

		private string _fname;   //10

		public string FirstName
		{
			get { return _fname; }
			set
			{
				if ((value.Length > 10) || string.IsNullOrEmpty(value))
				{
					throw new Exception("first name do not exceed 10 char");
				}
				else
				{
					_fname = value;

				}
			}
		}


					
					
		    


		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private DateTime _birthdate;

		public DateTime BirthDate
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}




	}
}
