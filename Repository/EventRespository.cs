using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class EventRespository
    {
        private readonly EventContext _context = null;

        public EventRespository(EventContext context)
        {
            _context = context;
        }
        public async Task<string> AddNewEvent(EventModel model)
        {
            var newEvent = new Events()
            {
                Title = model.Title,
                Email = model.Email,
                Date = model.Date,
                Location = model.Location,
                Starttime = model.Starttime,
                Type = model.Type,
                Description = model.Description,
                Duration = model.Duration,
                Details = model.Details,
                Invitations = model.Invitations
            };

            await _context.Events.AddAsync(newEvent);
            await _context.SaveChangesAsync();

            return newEvent.Title;
        }

        public async Task<List<EventModel>> GetEvents()
        {
            var events = new List<EventModel>();
            var allevents = await _context.Events.ToListAsync();
            if (allevents?.Any() == true)
            {
                foreach (var eve in allevents)
                {
                    events.Add(new EventModel()
                    {
                        Title = eve.Title,
                        Email = eve.Email,
                        Date = eve.Date,
                        Location = eve.Location,
                        Starttime = eve.Starttime,
                        Type = eve.Type,
                        Duration = eve.Duration,
                        Description = eve.Description,
                        Details = eve.Details,
                        Invitations = eve.Invitations

                    });
                }
            }
            return events;
        }

        public List<EventModel> GetEventByTitle(string title)
        {
            var event1 = _context.Events.FirstOrDefault(x => x.Title == title);
            var eventDetails = new List<EventModel>();
            if (event1 != null)
            {
                eventDetails.Add(new EventModel()
                {
                    Title = event1.Title,
                    Email = event1.Email,
                    Date = event1.Date,
                    Location = event1.Location,
                    Starttime = event1.Starttime,
                    Type = event1.Type,
                    Duration = event1.Duration,
                    Description = event1.Description,
                    Details = event1.Details,
                    Invitations = event1.Invitations,

                });
            }
            return eventDetails;
        }

        public List<EventModel> Edit(string title)
        {
            var event1 = _context.Events.FirstOrDefault(x => x.Title == title);
            var eventDetails = new List<EventModel>();
            if (event1 != null)
            {
                eventDetails.Add(new EventModel()
                {
                    Title = event1.Title,
                    Email = event1.Email,
                    Date = event1.Date,
                    Location = event1.Location,
                    Starttime = event1.Starttime,
                    Type = event1.Type,
                    Duration = event1.Duration,
                    Description = event1.Description,
                    Details = event1.Details,
                    Invitations = event1.Invitations,

                });
            }
            return eventDetails;
        }
        public EventModel EditEvent(EventModel model)
        {
            var event1 = _context.Events.FirstOrDefault(s => s.Title == model.Title);
            var eventModel = new EventModel()
            {
                Title = event1.Title,
                Email = event1.Email,
                Date = event1.Date,
                Location = event1.Location,
                Starttime = event1.Starttime,
                Type = event1.Type,
                Duration = event1.Duration,
                Description = event1.Description,
                Details = event1.Details,
                Invitations = event1.Invitations,
            };
            return eventModel;
        }
        
    }
}
