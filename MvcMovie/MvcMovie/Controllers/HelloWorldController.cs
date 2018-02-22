using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //HTTP 端點是 Web 應用程式中的可設定目標 URL 
        // 原網址後加上 /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // 原網址後加上 /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}