using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestWeb
{
    public class BuildingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
