using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_EFCore03.Models
{
    public class DepartmetEmployeeView
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int EmployeeId { get; set; }  
        public string EmployeeName { get; set; }

        public override string ToString()
        {
            return $"DepartmentId => {DepartmentId} && DepartmentName => {DepartmentName} &&  EmployeeId => {EmployeeId} && EmployeeName => {EmployeeName}";
        }
    }
}
