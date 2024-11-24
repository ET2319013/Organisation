using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Organisation
{
	[XmlRoot("OrganisationInfo")]
	public class Organisation
	{
		public Organisation() {
			departamentList = new List<Departament>();
		}

		public bool RemoveDep(Departament dep)
		{
			if (departamentList.Contains(dep))
			{
				departamentList.Remove(dep);
				return true;
			}
			else
			{
				foreach(var departament in departamentList) { 
					if (departament.RemoveSubdep(dep)) 
						return true;
				}
				return false;
			}
		}

		[XmlArray("departamentList")]
		public List<Departament> departamentList;
		public void SaveToFile (string name)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Departament));
			using (TextWriter writer = new StreamWriter(name))
			{
				foreach (var item in departamentList)
				{
					serializer.Serialize(writer, item);
				}
			}

		}
		public void LoadFromFile(string name)
		{
			departamentList.Clear();
			XmlSerializer serializer = new XmlSerializer(typeof(Departament));
			using (TextReader reader = new StreamReader(name))
			{
				var res = serializer.Deserialize(reader) as Departament;
				if(res != null)
					departamentList.Add(res);
			}
		}
	}
}
