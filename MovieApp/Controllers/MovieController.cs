using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private static IList<Movie> s_movie = new List<Movie>
        {
            new Movie
            {
                Id =3,
                Title ="peaky Blinders",
                Description ="adventure and historical",
                Year = 2014,
                Genre = Genre.Action
            },
            new Movie
            {
                Id =1,
                Title ="pretty woman",
                Description ="comedy",
                Year = 2002,
                Genre = Genre.Comedy
            },
            new Movie
            {
                Id =2,
                Title ="Titanic",
                Description ="romance and historical",
                Year = 2002,
                Genre = Genre.Romance
            }
        };
        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return s_movie;
        }
        //id-to go vnesuva toj od frontendot
        [HttpGet("{Id}")]
        public ActionResult<Movie> GetById(int Id)
        {
            var movie = s_movie.SingleOrDefault(m => m.Id == Id);
            if (movie == null)
            {
                return NotFound("the movie does not exist");
            }
            return movie;
        }

        [HttpGet("getbyGenre/{Genre}")]
        public ActionResult<Movie> GetByGenre(Genre Genre)
        {
            var genre_movie = s_movie.SingleOrDefault(m => m.Genre == Genre);
            if (genre_movie == null)
            {
                return NotFound("the movie does not exist");
            }
            return genre_movie;
        }


        [HttpPost]
        public ActionResult CreateNewMovie([FromBody]Movie movie)
        {
            if(s_movie.Any(m => m.Title == movie.Title))
            {
                return Conflict("The movie already exists!");
            }
            s_movie.Add(movie);
            return Ok("movie is created!");
        }
    }
}