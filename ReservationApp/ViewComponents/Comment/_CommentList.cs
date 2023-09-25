using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        private CommentManager _commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.GetCommentByDestinationId(id);
            return View(values);
        }
    }
}
