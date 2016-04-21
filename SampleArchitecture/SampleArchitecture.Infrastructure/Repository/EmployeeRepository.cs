using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleArchitecture.Core.POCOClasses;

namespace SampleArchitecture.Infrastructure.Repository
{
    public class EmployeeRepository
    {
        TestEntities _entities;

        public List<EmployeesUI> GetAllEmployees()
        {
            _entities = new TestEntities();
            var _listEmployeesUI = new List<EmployeesUI>();
            var _listEmployees = _entities.GetEmployees().ToList();
            foreach (var employee in _listEmployees)
            {
                _listEmployeesUI.Add(new EmployeesUI 
                { 
                    EmployeeId = employee.Id
                    , FirstName = employee.FirstName
                    , LastName = employee.LastName
                    , ManagerId = employee.ManagerId
                    , Manager = employee.Manager
                });
            }
            return _listEmployeesUI;
        }
    }
}
