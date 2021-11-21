using System;
using Microsoft.AspNetCore.Mvc;
using MyInfo.Models;


namespace MyInfo.Controllers
{
    public class DoctorController : Controller
    {
      
        public IActionResult FeverCheck()
        {
           
            return View();
        }

      
        public IActionResult FeverResult(double temp)
        {
            ViewBag.message = Doctor.checkFever(temp);
            return View();
        }
     
       
    }
}
