using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Organisation
{
	[Serializable]
	[XmlRoot("Empl")]
	public class Empl
	{
		public Empl(string n, string p) {
			Name = n;
			Position = p;
		}
		public Empl()
		{

		}

		[XmlElement("Name")]
		public string Name { get; set; } = string.Empty;
		[XmlElement("Position")]

		public string Position { get; set; } = string.Empty;
		//public Departament departament { get; set; }
	}
}
