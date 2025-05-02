using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.Controllers.DAL.Context;
using MyPortfolioUdemy.Migrations;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ExperinceComponentPartial :ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
