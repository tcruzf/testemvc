using Microsoft.AspNetCore.Mvc;
using WebSalesMvc.Models;

namespace WebSalesMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list = new List<Departments>();
            list.Add(new Departments { Id = 1, Name = "Eletronics" });
            list.Add(new Departments { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
