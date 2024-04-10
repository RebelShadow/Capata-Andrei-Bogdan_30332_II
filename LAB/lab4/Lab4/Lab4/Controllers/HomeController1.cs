using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("CtoF")]
        public ActionResult<double> ConvertCtoF( int c)
        {
            return (c * 9 / 5) + 32;
        }

        [HttpGet("FtoC")]
        public ActionResult<double> ConvertFtoC( int f)
        {
            return (f - 32) * 5 / 9;
        }

        [HttpGet("DateTime")]
        public ActionResult<DateTime> GetDateTime()
        {
            return DateTime.Now;
        }

        [HttpGet("RonEur")]
        public ActionResult<double> GetCurrency(double r)
        {
            return r * 0.2;
        }

        [HttpGet("List")]
        public ActionResult<List<String>> GetList()
        {
            var elem = new List<String> { "Car", "Home", "Dog", "Door", "Table" };
            return elem;
        }
        
    }
}
