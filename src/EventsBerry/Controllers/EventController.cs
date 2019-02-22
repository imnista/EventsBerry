using EventsBerry.Model;
using EventsBerry.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EventsBerry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private static readonly EventRepository eventRepository = new EventRepository();

        // GET: api/Event
        [HttpGet]
        public dynamic Get()
        {
            //var query =
            //    from u in eventRepository.AsQueryable()
            //    orderby u.CreatedTime descending
            //    select new
            //    {
            //        Id = u.Id,
            //        OrganizerId = u.OrganizerId,
            //        OrganizerDisplayName = u.OrganizerDisplayName,
            //        TimeRange = u.TimeRange,
            //        Topic = u.Topic,
            //        Description = u.Description,
            //    };
            //return query.ToList();

            return eventRepository.GetAll();
        }

        // GET: api/Event/5xxx
        [HttpGet("{id}", Name = "Get")]
        public Event Get(string id)
        {
            return eventRepository.Get(id);
        }

        // POST: api/Event
        [HttpPost]
        public ActionResult Post(Event value) // [FromForm]
        {
            value.CreatedTime = DateTime.UtcNow;
            eventRepository.Add(value);
            return this.Ok("Create new event successfully");
        }

        //// PUT: api/Event/5xxx
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            eventRepository.DeleteAsync(id);
        }
    }
}
