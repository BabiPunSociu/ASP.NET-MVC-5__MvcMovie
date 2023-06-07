using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;    // để dùng HtmlEncoder.Default.Encode   -> để bảo vệ ứng dụng khỏi đầu vào độc hại, như thông qua JavaScript

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //  GET: /HelloWorld/

        public IActionResult Index()   // index là phương thức mặc định, nếu URL không chỉ rõ phương thức thì sẽ chạy method index()
        {
            return View();
        }


        //  GET: /HelloWorld/Welcome/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
