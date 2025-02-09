using Basic_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer
            {
                FirstName = "Osman",
                LastName = "Özyaşar",
                Email = "oo@gmail.com",
                Id = 1
            };
            List<Order> orders = new List<Order>()
            {
                new Order { ProductName = "Lahmacun", Quentity = 2, Price = 55, Id = 1},
                new Order { ProductName = "Baklava", Quentity = 1, Price = 150, Id = 2},
                new Order { ProductName = "Yuvalama", Quentity = 1, Price = 200, Id = 3}
            };

            CustomerOrderViewModel viewModel = new CustomerOrderViewModel
            {
                 Customer = customer,
                 Orders = orders
            };
            return View(viewModel);
        }
    }
}
