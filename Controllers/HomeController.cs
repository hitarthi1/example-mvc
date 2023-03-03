using example_temp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace example_temp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            
            var viewModel = new MyViewModel

            {
                Name1 = "jfghdfjg",
                PartialViewModel=new MyPartialViewModel { Email ="hitarthi",Name ="patel"}  ,
                Email1 = "fkjfhdgj",
               

            
               
            };
            

            // Create an instance of MyViewModel and set its properties
            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SubmitForm(MyViewModel viewModel)
        {
            // do something with the form data
            // ...

            viewModel.PartialViewModel = new MyPartialViewModel
            {
                Name = viewModel.Name1,
                Email = viewModel.Email1
            };
            return PartialView("_MyPartialView", viewModel.PartialViewModel);
        }


    

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProcessForm()
        {
            string[] selectedFruits = Request.Form["fruit"];

            // Do something with the selectedFruits array

            return View();
       
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}