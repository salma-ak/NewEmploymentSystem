using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Data.Entities
{
    public class ClassDepartments
    {
        public class Department
        {
            [Key]
            public Guid Id { get; set; }
            public string Name { get; set; }
        }

    }
}
