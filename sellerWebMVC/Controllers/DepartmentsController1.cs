using Microsoft.AspNetCore.Mvc;
using sellerWebMVC.Models;
using System.Collections.Generic;

namespace sellerWebMVC.Controllers
{
    public class DepartmentsController1 : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
