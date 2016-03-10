using Sample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Services
{
    interface IRepositoryService
    {
        List<Employee> EmployeeList { get; set; }

        int EmpId { get; set; }
    }
}
