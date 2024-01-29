using ajax_class.Models;
using Microsoft.AspNetCore.Mvc;

namespace ajax_class.Controllers
{
    public class ApiController : Controller
    {
        private readonly MyDBContext _myDBContext;
        public ApiController(MyDBContext myDBContext) 
        {
            _myDBContext=myDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult jsonAddress()
        {
            var result = _myDBContext.Addresses.Select(a => a.City).Distinct();
            return Json(result);
        }
    }
}
