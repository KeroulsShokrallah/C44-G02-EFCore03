using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EFCore03.Models
{
    internal class FullTimeEmploee : Employee
    {
        public Decimal MonthlySalary { get; set; }

        public override string ToString()
        { 
            return $"Full time employe name = {Name} - id = {Id} - Email = {Email} - Address = {Adress} - monthlySalry = {MonthlySalary}";
        }

    }
}
