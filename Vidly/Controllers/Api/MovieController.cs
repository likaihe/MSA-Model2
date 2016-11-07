using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MovieController : ApiController
    {
        private ApplicationDbContext _context;

        private MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET/Api/Customers
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Movies.ToList());
        }

        public Movies moive(int id)
        {
            return _context.Movies.SingleOrDefault(c => c.Id == id);
        }

        // Delet/.../id
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var moviesDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (moviesDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(moviesDb);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteComment(int id)
        {
            var commentDb = _context.Comments.SingleOrDefault(c => c.Id == id);

            if (commentDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Comments.Remove(commentDb);

            _context.SaveChanges();
        }
    }
}
