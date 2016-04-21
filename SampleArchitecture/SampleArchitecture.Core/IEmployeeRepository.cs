using SampleArchitecture.Core.POCOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArchitecture.Core
{
    public interface IEmployeeRepository
    {
        List<EmployeesUI> GetAllEmployees();
    }
}
