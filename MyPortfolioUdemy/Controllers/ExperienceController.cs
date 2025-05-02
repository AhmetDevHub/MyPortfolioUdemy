using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.Controllers.DAL.Context;
using MyPortfolioUdemy.Controllers.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet] /* burası sayfa yüklenince çalışır*/
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost] /* sayfada bir buton tetiklendiği zaman çalışacak*/
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id) /* Silme İşlemi id ye göre yapılır*/
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
