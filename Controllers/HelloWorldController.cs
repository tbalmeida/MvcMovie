using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
  public class HelloWorldController : Controller
  {

    // GET /HelloWorld
    
    public IActionResult Index()
    {
      return View();

      // step 1 return "This is my default action...";
    }




    // GET: /HelloWorld/Welcome

    public IActionResult Welcome(string name, int numTimes = 1)
    {
      ViewData["Message"] = "Hello " + name;
      ViewData["NumTimes"] = numTimes;

      return View();
    }

    /* step 3
    public string Welcome(string name, int ID = 1)
    {
      return HtmlEncoder.Default.Encode($"Hello, {name}, ID: {ID}");
    }
    */


    /*
    // step 2
    public string Welcome(string name, int numTimes = 1)
    {
      return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
    */

    /* 
    // step 1
    public string Welcome()
    {
      return "This is the welcome action method...";
    }
    */


  }
}
