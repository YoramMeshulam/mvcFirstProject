using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        [Route("Movies/Random")]
        public ActionResult Random()
        {
            var NewMovie = new Movie { Id = 1, Name = "Sherk!" };
            var NewCustomers = new List<Customer>() { new Customer { Name = "Customer 1" }, new Customer { Name = "Customer 2" } };
            var NewRandomMovieViewModel = new RandomMovieViewModel() { Movie = NewMovie, Customers = NewCustomers };
            return View(NewRandomMovieViewModel);
            //return new HttpNotFoundResult();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }

        //public ActionResult Edit(int id)
        //{

        //    return Content("Edit id=" + id);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}, sortBy={1}", pageIndex, sortBy));
        //}
        //public ActionResult ByReleasedDate(int year, int month) {
        //    return Content(year+"/"+month);
        //}

        //http://localhost:62777/movies/byDate/2016/03
        //[Route("Movies/byDate/{year:regex(\\d{2})}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult byDatex(int? year, int? month)
        //{
        //    if (!year.HasValue)
        //        year = 1;
        //    if (!month.HasValue)
        //        month = 1;
        //    return Content("xxxxx year=" + year + ", month="+ month);
        //}
    }
}