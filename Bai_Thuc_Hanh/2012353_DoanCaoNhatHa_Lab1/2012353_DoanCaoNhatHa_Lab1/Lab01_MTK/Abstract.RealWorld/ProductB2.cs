using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.RealWorld
{
	class Wolf : Carnivore
	{
		public override void Eat(Herbivore h)
		{
			// Eat Bison
			Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
		}
	}
}
