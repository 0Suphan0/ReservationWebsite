using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Default
{
    public class _SubAboutPartial:ViewComponent
    {
        private SubAboutManager _manager = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values= _manager.GetAll();
            return View(values);
        }
    }
}
