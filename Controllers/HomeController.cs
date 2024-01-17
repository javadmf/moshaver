using Microsoft.AspNetCore.Mvc;
using moshaver.Models;
using System.Diagnostics;

namespace moshaver.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserRepository addUser;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            addUser=new UserRepository();
        }

        public IActionResult Index()

        {
            var user = new Users() { FirstName = "", LastName = "" };
           var resut= addUser.AddUser(user);
            if (resut.IsSuccessfull)
            { }
            else
            { 
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()

        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}