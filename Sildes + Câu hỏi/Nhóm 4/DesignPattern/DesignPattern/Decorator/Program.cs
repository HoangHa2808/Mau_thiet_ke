using Decorator.Base;
using Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Base price: 5$
             */

            /*
             * Topping
             * Bubble: 1$
             * BlackSugar: 2$
             * EggPudding: 3$
             * FruitPudding: 3$
             * WhiteBubble 1.5$
             */


            /*
             * EggPuddingAndFruitPuddingBlackSugarBubbleMilkTea
             * 14$
             */
            var firstMilkTea = new EggPudding(
                new FruitPudding(
                    new BlackSugar(
                        new Bubble(
                            new MilkTea()))));
            Console.WriteLine($"EggPuddingAndFruitPuddingBlackSugarBubbleMilkTea: {firstMilkTea.Cost()}");

            /*
             * EggPuddingBlackSugarWhiteBubbleMilkTea
             * 11.5$
             */
            var secondMilkTea = new EggPudding(
                new BlackSugar(
                    new WhiteBubble(
                        new MilkTea())));
            Console.WriteLine($"\nEggPuddingBlackSugarWhiteBubbleMilkTea: {secondMilkTea.Cost()}");

            Console.ReadKey(true);
        }
    }
}
