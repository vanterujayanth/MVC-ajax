using Microsoft.AspNetCore.Mvc;
using Mvc_Ajax.Entity;

namespace Mvc_Ajax.Controllers
{
    public class AjaxController : Controller
    {
       
        private readonly Context context;
       

        public AjaxController(Context context)
        {
            this.context = context;
            
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public JsonResult EmployeeList()
        {
            var data = this.context.Employees.ToList();
            return new JsonResult(data);
        }

        [HttpPost]

        public JsonResult AddEmployee(Employee employee)
        {
            Employee emp = new Employee()
            {
                Name = employee.Name,
                City = employee.City,
                State = employee.State,
                Salary = employee.Salary,
            };
            this.context.Employees.Add(emp);
            this.context.SaveChanges();
            return new JsonResult("Data is Saved");
        }

        public JsonResult Delete(int id)
        {
            var data = this.context.Employees.Where(e => e.Id == id).SingleOrDefault();
            this.context.Employees.Remove(data);
            this.context.SaveChanges();
            return new JsonResult("Data Delted");
        }

        public JsonResult Edit(int id)
        {
            var data = this.context.Employees.Where(e => e.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Update(Employee employee)
        {
            this.context.Employees.Update(employee);
            this.context.SaveChanges();
            return new JsonResult("Record updated");

        }
    }
}

