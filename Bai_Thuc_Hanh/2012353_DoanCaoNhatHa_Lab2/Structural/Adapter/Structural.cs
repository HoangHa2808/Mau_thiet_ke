using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Adapter
	{
		static void Main()
		{
			Target target = new Adapter();
			target.Request();
			// Wait for user
			Console.ReadKey();
		}


	}
}