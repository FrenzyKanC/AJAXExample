using AJAXExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AJAXExample.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Sherry", Age = 42});
            customers.Add(new CustomerModel { Id = 1, Name = "Melvin", Age = 18 });
            customers.Add(new CustomerModel { Id = 2, Name = "Velma", Age = 24 });
            customers.Add(new CustomerModel { Id = 3, Name = "Wendy", Age = 78 });
            customers.Add(new CustomerModel { Id = 4, Name = "Kim", Age = 20 });
            customers.Add(new CustomerModel { Id = 5, Name = "Jerry", Age = 35 });
        }
        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowOnePerson(int Id)
        {
            CustomerModel c = customers.FirstOrDefault(x => x.Id == Id);
            // es ist wichtig, dass die view auf eine partielle view geänder wird (c), da sonst das ajax die partielle anzeige nicht
            // anzeigen wird, sondern die standard view
            return View(c);
        }
    }
}
