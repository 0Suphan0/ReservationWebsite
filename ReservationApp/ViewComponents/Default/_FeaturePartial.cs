using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //buraya sonra bakılacak. verileri _FeaturePartial view'ına nasıl taşırız ?
            return View();
        }
    }
}
