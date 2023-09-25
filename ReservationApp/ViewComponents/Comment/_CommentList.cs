using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
