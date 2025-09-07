using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C44_G02_EFCore03.Context.Migrations
{
    /// <inheritdoc />
    public partial class departmetEmployeeView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create View DepartmetEmployeeView 
               as
               select e.Id as EmployeeId , e.Name as EmployeeName , d.Id as DepartmentId , d.Name as DepartmentName
               from Employees e join Departments d 
               on e.DepartmentId = d.Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View DepartmetEmployeeView");

        }
    }
}
