using System;
namespace HR.web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public DateTime HireDate { get; set; }
    }
}