using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly EventRespository _eventRespository = null;
        public HomeController(EventRespository eventRespository)
        {
            _eventRespository = eventRespository;
        }
        public async Task<ViewResult> Index()
        {
            var data = await _eventRespository.GetEvents();
            return View(data);
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
