using ajax_class.Models;
using ajax_class.Models.DOM;
using Microsoft.AspNetCore.Mvc;
using System.Text;

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
        public IActionResult returncontent()
        {
            //int a = 10;
            //int b = 0;
            //int c = a/b;
            //Thread.Sleep(1000);
            return Content("測試測試","text/html",Encoding.UTF8);
        }
        public IActionResult returnimg(int id)
        {
            Member? Members = _myDBContext.Members.Find(id);
            if (Members != null) 
            {
                byte[] img = Members.FileData;
                if (img != null) 
                {
                    return File(img, "image/jpeg");
                }
            }
            return NotFound();
        }
        public IActionResult resultquery(VMMember vMMember)
        {
            if (string.IsNullOrEmpty(vMMember.Name)) 
            {
                vMMember.Name = "未知";
            }
            return Content($"你好{vMMember.Name}，已經{vMMember.age}那麼大了");
        }
        public IActionResult CheckAccount(VMMember vMMember)
        {
            foreach (var Member in _myDBContext.Members) 
            {
                if (Member.Name == vMMember.Name) 
                {
                    return Content($" {vMMember.Name}已經存在了", "text/plain", Encoding.UTF8);
                }
            }
            if (vMMember.Name != null && vMMember.Email != null && vMMember.age != null) 
            {
                return Content($" 你好{vMMember.Name}，{vMMember.age}歲了，電子信箱是{vMMember.Email}", "text/plain", Encoding.UTF8);
            }
            return Content($"帳號可以使用", "text/plain", Encoding.UTF8);
        }
    }
}
