using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class TesterDepartment : Department
    {
        public TesterDepartment(string name) : base(name)
        {

        }

        public override void Add(Department department)
        {

        }

        public override void Display(int indent)
        {
            Console.WriteLine($"{new String('-', indent)} {name}");
        }

        public override void Remove(Department department)
        {

        }
    }
}
