using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrelloSession5.Models;

namespace TrelloSession5.Controllers
{
    public class TrelloController : Controller
    {
        // GET: Trello
        public ActionResult Index()
        {
            TrelloDbContext db = new TrelloDbContext();
            var results = db.Cards.OrderBy(x => x.SortOrder).ToList();
            return View(results);
        }

        public ActionResult Cards()
        {
            TrelloDbContext db = new TrelloDbContext();
            var results = db.Cards.OrderBy(x => x.SortOrder).ToList();
            return View(results);
        }

        public ActionResult AddCard(string text)
        {
            TrelloDbContext db = new TrelloDbContext();
            Card tempCard = new Card();
            tempCard.Text = text;
            db.Cards.Add(tempCard);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCard(int Id)
        {
            TrelloDbContext db = new TrelloDbContext();
            var cardToDelete = db.Cards.Find(Id);
            db.Cards.Remove(cardToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}