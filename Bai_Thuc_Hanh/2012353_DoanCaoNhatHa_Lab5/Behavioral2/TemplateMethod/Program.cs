﻿using System;

namespace Template
{
    /// <summary>
    /// MainApp startup class for Real-World
    /// Template Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    internal abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();

        public abstract void PrimitiveOperation2();

        // The "Template method"
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    internal class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    internal class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
    }
}