using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sample.TagHelpers.Controllers
{
    public class ComponentController : Controller
    {
        public IActionResult Input()
        {
            return View();
        }

    }
}
