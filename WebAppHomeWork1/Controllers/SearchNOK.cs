using Microsoft.AspNetCore.Mvc;
using WebAppHomeWork1.Models;
namespace WebAppHomeWork1.Controllers
{
    public class SearchNOK : Controller
    {
        public IActionResult Index(int number1, int number2)
        {
            @ViewData["Title"] = "НОК";
            ViewData["n1"] = number1;
            ViewData["n2"] = number2;
            
            ulong result = 0;

            SearchNOKModel sn = new SearchNOKModel(number1, number2);
            result = sn.nok();
            ViewData["res"] = result;
            return View();
        }
    }
}
