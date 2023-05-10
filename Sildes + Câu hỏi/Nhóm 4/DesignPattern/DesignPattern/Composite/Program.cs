using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            HeadDepartment headDepartment = new HeadDepartment("Head department");
            SoftwareDepartment softwareDepartment = new SoftwareDepartment("Software department");

            SalesDepartment salesDepartment = new SalesDepartment("Sales department");
            FinancialDepartment financialDepartment = new FinancialDepartment("Financial department");
            TesterDepartment testerDepartment = new TesterDepartment("Tester department");

            softwareDepartment.Add(testerDepartment);

            headDepartment.Add(salesDepartment);
            headDepartment.Add(financialDepartment);
            headDepartment.Add(softwareDepartment);

            headDepartment.Display(1);

            Console.ReadKey(true);
        }
    }
}
