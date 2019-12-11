using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESystem.Models;
using System.Data.Entity;
using ESystem.ViewModel;
using ESystem.Migrations;

namespace ESystem.Controllers
{
    public class RWAController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public RWAController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dbContext.Dispose();
            }
        }
        // GET: RWA
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CheckingEligibility()
        {
            return View();
        }
        [HttpPost]
        // [Route("RWA/CheckingEligibility/{id}")]
        public ActionResult CheckingEligibility(string id)
        {
            var CheckId = dbContext.ResidentDetails.Include(n => n.VotingMembers).Any(c => c.ResidentId == id);
            if (CheckId)
            {
                //var Position = dbContext.PositionForElections.ToList();
                //var newmodel = new RWAPositionViewModel
                //{
                //    Registration = new Registration(),
                //    PositionForElections = Position
                //};
                //return View("Create", newmodel);
                return View("Select");

            }
            else
            {
                return Content("Not Part Of Community");
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            var Position = dbContext.PositionForElections.ToList();


            var newmodel = new RWAPositionViewModel
            {
                Registration = new Registration(),
                PositionForElections = Position
            };
            return View(newmodel);
            // return View(Position);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RWAPositionViewModel rWA)
        {



            if (rWA.Registration.Id == 0)
            {
                dbContext.Registrations.Add(rWA.Registration);
            }

            dbContext.SaveChanges();

            return Content("Created");
        }
        [HttpGet]
        public ActionResult DisplayBallet()
        {
            var Ballet = dbContext.Registrations.Include(o => o.PositionForElections).ToList();
            return View(Ballet);
        }
        //[Route("DisplayBallet/RWA/{id}")]
        [HttpPost]
        public ActionResult DisplayBallet(int id)
        {

            //var vote = new Vote
            //{
            //    RegistrationId = id
            //};
            var ballet = dbContext.Registrations.FirstOrDefault(r => r.Id == id);
            ballet.Votes++;
            //dbContext.Votes.Add(vote);
            dbContext.SaveChanges();
            return Content("Saved");
        }
        [Route("RWA/Count")]
        public ActionResult Count()
        {
            var count = dbContext.Registrations.OrderByDescending(r => r.Votes).FirstOrDefault();
            return View(count);


            //var count1 = dbContext.Votes.Include(m => m.Registration).GroupBy(i => i.RegistrationId).ToList();
            //var grouped = count1.Select(i => new { Word = i.Key, Count = i.Count() ,Name=count1.});
            //var desc = grouped.OrderByDescending(i => i.Count).First();
            ////var word1 = dbContext.Registrations.Where(m => m.Id == desc.Word).Select(i=>new {Name= });
            //var word1 = dbContext.Registrations.Include(m => m.PositionForElections).Where(m => m.Id == desc.Word);
            ////return _context.Sates.Where(a => a.Id == id)
            ////                .GroupBy(a => a.StateId)
            ////                .Select(g => new { g.Key, Count = g.Count() });
            ////foreach (var item in count1)
            ////{
            ////    var c2 = item;

            ////}

            //return View(word1);

        }
    }
}
