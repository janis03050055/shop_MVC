using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //HTTP 端點是 Web 應用程式中的可設定目標 URL 
        // 原網址後加上 /HelloWorld/

        public IActionResult Index()
        {
            //因為沒有明確指定檢視範本檔案的名稱，MVC 預設為使用 /Views/HelloWorld 資料夾中的 Index.cshtml 檢視檔案。 
            return View();
        }

        // 
        // 原網址後加上 /HelloWorld/Welcome/ 
        // http://localhost:xxxx/HelloWorld/Welcome?name=Janis&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //將資料從控制端傳送到View，記得要return view
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}