using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR.web.Models.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }

        public int SelectedId { get; set; }
    }
}