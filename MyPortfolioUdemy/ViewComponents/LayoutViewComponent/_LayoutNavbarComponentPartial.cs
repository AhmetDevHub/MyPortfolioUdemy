using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.Controllers.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponent
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();  /*okunmamış olan bildirim saylarını*/
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();   /*yapılmamış olan metodları listeleyecek*/            
            return View(values);
        }
    }
}
