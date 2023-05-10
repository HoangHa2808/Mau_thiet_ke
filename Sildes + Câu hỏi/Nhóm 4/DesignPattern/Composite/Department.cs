using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Department
    {
        protected string name;

        protected Department(string name)
        {
            this.name = name;
        }

        public abstract void Add(Department department);
        public abstract void Remove(Department department);
        public abstract void Display(int indent);
    }
}
