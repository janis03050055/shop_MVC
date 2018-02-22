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
            //預設action
            return "This is my default action...";
        }

        // 
        // 原網址後加上 /HelloWorld/Welcome/ 
        // http://localhost:xxxx/HelloWorld/Welcome?name=Janis&numtimes=4
        public string Welcome(string name, int numTimes = 1)
        {
            //使用action並傳回[Parameters]
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}