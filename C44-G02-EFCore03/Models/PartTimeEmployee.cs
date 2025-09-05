using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EFCore03.Models
{
    internal class PartTimeEmployee : Employee
    {
        public int HourWorked { get; set; }
        public int HourlyRate { get; set; }

        public override string ToString()
        {
            return $"Part time employe name = {Name} - id = {Id} -" +
                $" Email = {Email} - Address = {Adress} - HourWorked = {HourWorked} - HourlyRate = {HourlyRate}";
        }

    }
}
