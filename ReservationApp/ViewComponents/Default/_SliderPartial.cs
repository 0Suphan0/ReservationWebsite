using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
