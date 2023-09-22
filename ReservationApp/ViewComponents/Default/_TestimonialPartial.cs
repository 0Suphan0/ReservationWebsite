using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        private TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.GetAll();
            return View(values);
        }
    }
}
