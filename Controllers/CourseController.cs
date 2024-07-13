using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
  public class CourseController : Controller
  {
    public IActionResult Index()
    {
      // Veritabanından başvuruları çekip View'e model olarak gönder
      var applications = Repository.Applications.ToList();
      return View(applications);
    }

    [HttpGet]
    public IActionResult Apply()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] // To ensure security
    public IActionResult Apply([FromForm] Candidate model)
    {
      if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
      {
        ModelState.AddModelError("Email", "Bu email adresi ile daha önce başvuru yapılmıştır.");
      }

      if (ModelState.IsValid)
      {
        Repository.Add(model);
        return View("Feedback", model);
      }

      return View();
    }
  }
}