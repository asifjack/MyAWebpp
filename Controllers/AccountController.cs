using Microsoft.AspNetCore.Mvc;
using MyAWebpp.Models;
using MyAWebpp.Service;

namespace MyAWebpp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("create")]
        public IActionResult Register()
        {
            //Service
            AninalService obj = new AninalService();
            var speed =obj.GetSpeed();

            return View();
        }

        
        [HttpPost]
        public IActionResult Register(Register register)
        {
            return View();
        }
    }
}
