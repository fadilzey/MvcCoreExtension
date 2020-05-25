using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcCoreExtension.Extensions;

namespace MvcCoreExtension.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string sayi = "5j"; 
            int sonuc = sayi.ConvertInt();

            List<int> list = new List<int>(); 

            if (list.HashElement())
            { 
               //yapılacak işlem
            }

            return View();
        }
    }
}