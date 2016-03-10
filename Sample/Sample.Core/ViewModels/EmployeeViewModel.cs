
using MvvmCross.Core.ViewModels;
using Sample.Core.Entity;
using Sample.Core.Messages;
using Sample.Core.Services;
using System.Collections.Generic;
using System.Windows.Input;

namespace Sample.Core.ViewModels
{
    /// <summary>
    /// View model for show employee list
    /// </summary>
    public class EmployeeViewModel
        : MvxViewModel
    {
        #region Private Members
        private List<Employee> employeeList;
        private ICommand cmdEmployeeSeleceted;
        private MvxCommand cmdEmpAdd;

        #endregion

        #region Properties
        public ICommand CmdEmployeeSelected
        {
            get
            {
                this.cmdEmployeeSeleceted = this.cmdEmployeeSeleceted ?? (this.cmdEmployeeSeleceted = new MvxCommand<Employee>(E => this.doEmployeeSelected(E)));

                return (this.cmdEmployeeSeleceted);
            }
        }

        public ICommand CmdEmpAdd
        {
            get
            {
                this.cmdEmpAdd = this.cmdEmpAdd ?? (this.cmdEmpAdd = new MvxCommand(() => doEmployeeAdd()));
                return cmdEmpAdd;
            }
        }

        /// <summary>
        /// Surface the Employee List
        /// </summary>
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

        #region Constructor
        public EmployeeViewModel()
        {
            DoInitialize();
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Initialize data
        /// </summary>
        private void DoInitialize()
        {
            this.EmployeeList = new List<Employee>
            {
                new Employee() {Name = "Emp1", Id = 1, PhoneNo = 1234, Address="test1" },
                new Employee() {Name = "Emp2", Id = 2, PhoneNo = 5678, Address="test2" },
                new Employee() {Name = "Emp3", Id = 3, PhoneNo = 7979, Address="test3" }
            };
        }

        private void doEmployeeSelected(Employee employee)
        {
            // Protect...
            if (employee == null)
                return;
            RepositoryService.EmpId = employee.Id;
            ShowViewModel<EmployeeDetailViewModel>();
        }

        private void doEmployeeAdd()
        {
            RepositoryService.EmpId = 0;
            ShowViewModel<EmployeeDetailViewModel>();
        }

        #endregion
    }

}
