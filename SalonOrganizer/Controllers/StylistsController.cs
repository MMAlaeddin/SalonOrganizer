using Microsoft.AspNetCore.Mvc;
using SalonOrganizer.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace SalonOrganizer.Controllers
{
  public class StylistsController : Controller
  {
    private readonly SalonOrganizerContext _db;
    
    public StylistsController(SalonOrganizerContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var fireMyStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
      return View(fireMyStylist);
    }
    [HttpPost, ActionName ("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var fireMyStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
      _db.Remove(fireMyStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylists => stylists.StylistId == id);
      return View(thisStylist);
    }
    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      thisStylist.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      return View(thisStylist);
    }
  }
}