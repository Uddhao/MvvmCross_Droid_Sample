
using Chance.MvvmCross.Plugins.UserInteraction;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Sample.Core.Entity;
using Sample.Core.Messages;
using Sample.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Sample.Core.ViewModels
{
    /// <summary>
    /// View Model for Add/Edit/Show employee details
    /// </summary>
    public class EmployeeDetailViewModel
        : MvxViewModel
    {
        #region Private Members


        private Employee employee = new Employee();
        private MvxCommand cmdEmpSave;

        private int empId;
        private string empName;
        private int phonNo;

        #endregion

        #region Properties
        public ICommand CmdEmpSave
        {
            get
            {
                return this.cmdEmpSave ?? (this.cmdEmpSave = new MvxCommand(() => this.doEmployeeSave()));
            }
        }

        public Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                RaisePropertyChanged(() => Employee);
            }
        }

        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
                RaisePropertyChanged(() => EmpName);
            }
        }

        public int PhoneNo
        {
            get
            {
                return phonNo;
            }
            set
            {
                phonNo = value;
                RaisePropertyChanged(() => PhoneNo);
            }
        }

        public List<Employee> EmployeeList
        {
            get
            {
                return RepositoryService.EmployeeList;
            }
            set
            {
                RepositoryService.EmployeeList = value;
                RaisePropertyChanged(() => EmployeeList);
            }
        }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeDetailViewModel()
        {
            empId = RepositoryService.EmpId;
            DoDataInitialize();
        }

        /// <summary>
        /// Initialize data
        /// </summary>
        private void DoDataInitialize()
        {           
            if(empId != 0)
            {
                this.Employee = this.EmployeeList.Where(e => e.Id == empId).FirstOrDefault();
                this.EmpName = this.Employee.Name;
                this.PhoneNo = this.Employee.PhoneNo;
            }
           
        }

        /// <summary>
        /// 
        /// </summary>
        private void doEmployeeSave()
        {
            // Here Employee Name getting always null.. 
            if(string.IsNullOrWhiteSpace(EmpName))
            {
                 Mvx.Resolve<IUserInteraction>().Alert("Please Enter Employee Name..");
                 
            }
            this.Employee.Name = EmpName;
            this.Employee.PhoneNo = PhoneNo;

            RepositoryService.EmployeeList.Add(this.Employee);
        }
    }
}
