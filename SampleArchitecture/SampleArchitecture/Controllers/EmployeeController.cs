using SampleArchitecture.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleArchitecture.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var _repository = new EmployeeRepository();
            var _listUsers = _repository.GetAllEmployees();
            return View(_listUsers);
        }
    }
}
