using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organisation
{
	[Serializable]
	class Empl
	{
		public Empl(string n, string p) {
			name = n;
			position = p;
		}
		public string name { get; set; }
		public string position { get; set; }
		//public Departament departament { get; set; }
	}
}
