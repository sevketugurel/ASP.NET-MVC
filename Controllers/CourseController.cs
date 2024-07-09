using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
  public class CourseController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Apply()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken] //güvenliği sağlamak için

    public IActionResult Apply([FromForm] Candidate model) //yine güvenlik için nereden geldiğini söylememiz iyi olur
    {
      Repository.Add(model); //modeli repository'e ekliyoruz
      return View("Feedback", model); //feedback sayfasına yönlendiriyoruz
    }
  }
}