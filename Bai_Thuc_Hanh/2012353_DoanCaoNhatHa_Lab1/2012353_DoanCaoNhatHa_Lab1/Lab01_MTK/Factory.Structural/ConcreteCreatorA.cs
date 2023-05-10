﻿namespace Factory.Structural
{
	class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductA();
		}
	}
}