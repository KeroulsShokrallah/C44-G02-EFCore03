using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EFCore03.Models
{
    public  class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int Id {  get; set; }
        public string Email { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;


        // Relations

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; } = default;

    }
}
