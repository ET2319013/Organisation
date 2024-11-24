using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Organisation
{
	[Serializable]
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
			XmlSerializer serializer = new XmlSerializer(typeof(Organisation));
			using (TextWriter writer = new StreamWriter(name))
				serializer.Serialize(writer, this);
			//{
			//	foreach (var item in departamentList)
			//	{
			//		serializer.Serialize(writer, item);
			//	}
			//}

		}
		public void LoadFromFile(string name)
		{
			departamentList.Clear();
			XmlSerializer serializer = new XmlSerializer(typeof(Organisation));
			using (TextReader reader = new StreamReader(name))
			{
				var res = serializer.Deserialize(reader) as Organisation;
				if(res != null)
				{
					departamentList.Clear();
					foreach (var departament in res.departamentList)
					{
						departamentList.Add(departament);
					}
				}
				
			}
		}
	}
}
