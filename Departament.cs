using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organisation
{
	[Serializable]
	class Departament 
	{
		public Departament() {
			name = "";
			manager = "";
		}

		public Departament(string n, string m)
		{
			name = n;
			manager = m;
		}

		public string name { get; set; }
		public string manager { get; set; }
		public List<Empl> employees { get; set; } = new List<Empl>();
		public List<Departament> sub_deps { get; set; } = new List<Departament>();

		public Departament? FindDep(string name)
		{
			return sub_deps.FirstOrDefault(e => e.name == name);
		}
		public void AddSubDep(Departament sub_dep)
		{
			sub_deps.Add(sub_dep);
		}

		public void AddEmpl(Empl empl)
		{
			employees.Add(empl);
		}

		public bool RemoveEmpl(Empl empl)
		{
			return employees.Remove(empl);
		}

		public bool RemoveSubdep(Departament subdep)
		{
			if(sub_deps.Contains(subdep))
			{
				return sub_deps.Remove(subdep);
			}
			else
			{
				foreach(Departament dep in sub_deps)
				{
					if(dep.RemoveSubdep(dep))
						return true;
				}
			}
			return false;

		}

	}



}
