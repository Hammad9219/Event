using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class EventContext : IdentityDbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
            
        }
        public DbSet<Events> Events { get; set; }
    }
}
