using Microsoft.AspNetCore.Mvc;
using SalonOrganizer.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace SalonOrganizer.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonOrganizerContext _db;

    public ClientsController(SalonOrganizerContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }
  }
}