using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
