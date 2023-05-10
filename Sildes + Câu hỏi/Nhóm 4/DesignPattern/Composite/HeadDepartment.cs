using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class HeadDepartment : Department
    {
        List<Department> departments;

        public HeadDepartment(string name) : base(name)
        {
            departments = new List<Department>();
        }

        public override void Add(Department department)
        {
            departments.Add(department);
        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new String('-', indent)} {name}");

            foreach (Department item in departments)
            {
                item.Display(indent + 2);
            }
        }

        public override void Remove(Department department)
        {
            departments.Remove(department);
        }
    }
}
