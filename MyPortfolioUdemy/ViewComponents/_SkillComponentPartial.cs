using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.Controllers.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
      
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
           
            return View(values);
        }
    }
}
