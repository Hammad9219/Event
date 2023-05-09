using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class EventController : Controller
    {
        private readonly EventRespository _eventRespository = null;
        public EventController(EventRespository eventRespository)
        {
            _eventRespository = eventRespository;
        }

        public async Task<ViewResult> GetEvents()
        {
            var data = await _eventRespository.GetEvents();
            return View(data);
        }

        public ViewResult CreateEvent(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }

        
        public ActionResult GetEventByTitle(string title)
        {
            var  data = _eventRespository.GetEventByTitle(title);
            return View(data);
        }


        [HttpPost]
        public IActionResult CreateEvent(EventModel eventmodel)
        {
            if (ModelState.IsValid)
            {
                var str = _eventRespository.AddNewEvent(eventmodel);
                if (str != null)
                {
                    return RedirectToAction(nameof(CreateEvent), new { isSuccess = true });
                }
            }
            ViewBag.IsSuccess = false;
            return View();
        }

        public async Task<ViewResult> Invitation()
        {
            var data = await _eventRespository.GetEvents();
            return View(data);
        }

        public async Task<ViewResult> MyEvents()
        {
            var data = await _eventRespository.GetEvents();
            return View(data);
        }

        public ViewResult Edit(string title)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            var std = _eventRespository.Edit(title);
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(EventModel eventModel)
        {
            //update student in DB using EntityFramework in real-life application
            //update list by removing old student and adding updated student for demo purpose
            var str = _eventRespository.EditEvent(eventModel);
            _=_eventRespository.AddNewEvent(eventModel);
            return RedirectToAction("MyEvents");
        }
    }
}
