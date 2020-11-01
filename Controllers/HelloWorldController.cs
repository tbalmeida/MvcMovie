﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
  public class HelloWorldController : Controller
  {

    // GET /HelloWorld
    
    public string Index()
    {
      return "This is my default action...";
    }


    // GET: /HelloWorld/Welcome

    public string Welcome(string name, int ID = 1)
    {
      return HtmlEncoder.Default.Encode($"Hello, {name}, ID: {ID}");
    }


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
