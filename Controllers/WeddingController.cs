using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LoginReg.Controllers
{
    public class WeddingController : Controller
    {
        private LoginRegContext dbContext;

        public WeddingController(LoginRegContext context)
        {
            dbContext = context;
        }

        [Route("success")]
        [HttpGet]
        public IActionResult Success()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");
            if(userId == null)
                return RedirectToAction("Index","Home");
            List<Wedding>AllWeddings=dbContext.Weddings
                .Include(w => w.Guests)
                .ThenInclude(a => a.User)
                .ToList();
            ViewBag.UserId = userId;
            Console.WriteLine(userId);


            return View("Success", AllWeddings);
        }

        [Route("/add/wedding")]
        [HttpGet]
        public IActionResult AddWedding()
        {
             return View("AddWedding");
        }

        
        [Route("/create/wedding")]
        [HttpPost]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            dbContext.Add(newWedding);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }

        [Route("/add/{userId}/{weddingId}")]
        [HttpGet]
        public IActionResult AddUserToWedding(int userId, int weddingId)
        {
            Wedding oneWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            User oneUser = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            Association newAssociation = new Association()
            {
               WeddingId = oneWedding.WeddingId,
               UserId = oneUser.UserId 
            };
            dbContext.Associations.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }
        [Route("/remove/{userId}/{weddingId}")]
        [HttpGet]
        public IActionResult RemoveUserFromWedding(int userId, int weddingId)
        {
            Wedding oneWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            User oneUser = dbContext.Users.FirstOrDefault(u => u.UserId == userId);
            Association oneAssociation = dbContext.Associations.FirstOrDefault(a => a.UserId == userId && a.WeddingId == weddingId);

            oneWedding.Guests.Remove(oneAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }
        [Route("/view/{weddingId}")]
        [HttpGet]
        public IActionResult ViewWedding(int weddingId)
        { 
            List<Association> users = dbContext.Associations
            .Include(u => u.User)
             .Where(u => u.WeddingId == weddingId)
             .ToList(); 


            Wedding oneWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            return View(oneWedding);
        }
    }
}
