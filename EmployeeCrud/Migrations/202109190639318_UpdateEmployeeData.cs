namespace EmployeeCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Employees(EmployeeName,Email,TrainingProgram,DepartmentId)" +
                "Values('KM','km@gmail.com','Training01',1)");

        }

        public override void Down()
        {
        }
    }
}
