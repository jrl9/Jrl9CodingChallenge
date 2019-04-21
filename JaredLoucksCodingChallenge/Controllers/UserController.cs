using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace JaredLoucksCodingChallenge.Controllers
{
    public class UserController : Controller
    {
        
        // GET: User/Index
        public ViewResult Index()
        {

            var user = new JaredLoucksCodingChallenge.Models.User() { Id = 1, FirstName = "Jared", LastName = "Loucks" };

            var projects = new List<JaredLoucksCodingChallenge.Models.Project>
            {

                new JaredLoucksCodingChallenge.Models.Project { Id = 1},
                new JaredLoucksCodingChallenge.Models.Project { Id = 2},
                new JaredLoucksCodingChallenge.Models.Project { Id = 3}

            };

            var viewModel = new JaredLoucksCodingChallenge.ViewModels.IndexViewModel()
            {
                User = user,
                Projects = projects
            };

            return View(viewModel);

            //Do not use ViewData or ViewBag, poor replacement for the above method
        }

        //Attribute Route
        //[Route("User/Index")]

        //Action Route - Index (test)
        /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Id";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/

    }

        public class ChallengeDBContext : DbContext
    {
        public DbSet<UserController> Users { get; set; }
    }
}