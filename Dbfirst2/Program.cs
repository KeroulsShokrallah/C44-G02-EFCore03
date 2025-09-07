using Dbfirst2.Context;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Threading.Tasks;

namespace Dbfirst2
{
    internal class Program
    {
        static async Task Main()
        {
           var context = new NorthwindContext();


            foreach (var item in context.Products)
            {
                Console.WriteLine(item.ProductName);
            }
            var result = await  context.Procedures.SelectALLEmployeesAsync();
            Console.WriteLine();
            foreach(var employee in result)
            {
                Console.WriteLine(employee.FirstName);
            }
        }
    }
}
