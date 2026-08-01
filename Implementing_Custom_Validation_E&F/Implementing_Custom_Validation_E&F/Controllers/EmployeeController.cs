using System;
using System.ComponentModel.DataAnnotations;
using Implementing_Custom_Validation_E_F.Models;
using Microsoft.AspNetCore.Mvc;

namespace Implementing_Custom_Validation_E_F.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            var model = new Employee
            {
                Skills = Skills.None
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Employee employee, string[] skillsSelected)
        {
            if (skillsSelected != null && skillsSelected.Length > 0)
            {
                employee.Skills = Skills.None;
                foreach (var s in skillsSelected)
                {
                    employee.Skills |= Enum.Parse<Skills>(s);
                }
            }
            if (ModelState.IsValid)
            {
                return View("Success", employee);
            }
            return View(employee);
        }
        public IActionResult Success(Employee employee)
        {
            return View(employee);
        }
    }

    //[Flags]
    //public enum Skills
    //{
    //    None = 0,
    //    CSharp = 1,
    //    ASPNetCore = 2,
    //    SQL = 4,
    //    Javascript = 8
    //}

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Department Department { get; set; }
    //    public Skills Skills { get; set; }
    //}
}
