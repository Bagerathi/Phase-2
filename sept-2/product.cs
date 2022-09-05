using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class products
    {
		private int _prodid;

		public int ProdID
		{
			get { return _prodid; }
			set { _prodid = value; }
		}


		private int _prodname;

		public int ProductName
		{
			get { return _prodname; }
			set { _prodname = value; }
		}

	}
}
