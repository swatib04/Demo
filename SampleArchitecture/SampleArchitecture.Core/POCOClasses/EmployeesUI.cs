using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleArchitecture.Core.POCOClasses
{
    public class EmployeesUI
    {
        public Int32 EmployeeId 
        { 
            get; 
            set; 
        }

        [Required]
        public String FirstName 
        { 
            get; 
            set; 
        }
        
        [Required]
        public String LastName 
        { 
            get; 
            set; 
        }

        public Int32? ManagerId 
        { 
            get; 
            set; 
        }
    }
}
