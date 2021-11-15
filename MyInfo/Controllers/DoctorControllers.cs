using System;
using Microsoft.AspNetCore.Mvc;
namespace MyInfo.Controllers
{
    public class DoctorControllers : Controller
    {
        public IActionResult FeverCheck()
        {
            return View();
        }
    }
}
