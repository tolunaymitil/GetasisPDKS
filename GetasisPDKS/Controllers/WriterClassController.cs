using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class WriterClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            //var JsonWriters = JsonConvert.SerializeObject(writers);
            var JsonWriters = writers;
            return Json(JsonWriters);
        }
        [HttpGet]
        public IActionResult PersonelAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PersonelAdd([FromBody]WriterClass writerClass)
        {
            writers.Add(writerClass);
            return Ok(writerClass);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id=1, 
                Name="Tolga"
            },
            new WriterClass
            {
                Id=2, 
                Name="Tolunay"
            },
            new WriterClass
            {
                Id=3, 
                Name="Turan"
            },

        };


    }
     
}