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
			Name = "";
			Manager = "";
		}

		public Departament(string n, string m)
		{
			Name = n;
			Manager = m;
		}

		public string Name { get; set; }
		public string Manager { get; set; }
		public List<Empl> Employees { get; set; } = new List<Empl>();
		public List<Departament> Sub_deps { get; set; } = new List<Departament>();

		public Departament? FindDep(string name)
		{
			return Sub_deps.FirstOrDefault(e => e.Name == name);
		}
		public void AddSubDep(Departament sub_dep)
		{
			Sub_deps.Add(sub_dep);
		}

		public void AddEmpl(Empl empl)
		{
			Employees.Add(empl);
		}

		public bool RemoveEmpl(Empl empl)
		{
			return Employees.Remove(empl);
		}

		public bool RemoveSubdep(Departament subdep)
		{
			if(Sub_deps.Contains(subdep))
			{
				return Sub_deps.Remove(subdep);
			}
			else
			{
				foreach(Departament dep in Sub_deps)
				{
					if(dep.RemoveSubdep(dep))
						return true;
				}
			}
			return false;

		}

	}



}
