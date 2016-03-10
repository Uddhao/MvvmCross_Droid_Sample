using Sample.Core.Entity;
using Sample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Core.Services
{
    public static class RepositoryService 
    {
        private static  List<Employee> employeeList;
        public static List<Employee> EmployeeList
        {
            get
            {
                if(employeeList == null)
                {
                    employeeList = new List<Employee>();
                }
                return employeeList;
            }
            set
            {
                employeeList = value;
            }
        }

        public static int EmpId { get; set; }
    }
}
