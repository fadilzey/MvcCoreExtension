using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCoreExtension.Extensions;
using Newtonsoft.Json;

namespace MvcCoreExtension.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            #region 1
            
            HttpContext.Session.SetString("session", "deneme");
            var test = HttpContext.Session.GetString("session");

            #endregion

            #region 2

            string sayi = "5j";
            int sonuc = sayi.ConvertInt();

            #endregion


            #region 3

            List<int> list1 = new List<int>() { 1, 2, 3 };
            HttpContext.Session.SetString("sessionlist", JsonConvert.SerializeObject(list1));

            var value = HttpContext.Session.GetString("sessionlist");
            var list2 = JsonConvert.DeserializeObject<int[]>(value);


            list1 = new List<int>() { 4, 5, 6 };
            HttpContext.Session.SetObject("listsession", list1);
            var list3 = HttpContext.Session.GetObject<int[]>("listsession");

            #endregion

            #region 4

            List<int> list = new List<int>();

            if (list.HashElement())
            {
                //yapılacak işlem
            } 
            #endregion

            return View();
        }
    }
}