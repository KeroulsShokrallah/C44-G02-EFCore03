using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EFCore03.Models
{
    public class Department
    {
        public int Id { get; set; } = default;
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = [];
        
    }
}
