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
			Name = n;
			Position = p;
		}
		public string Name { get; set; }
		public string Position { get; set; }
		//public Departament departament { get; set; }
	}
}
