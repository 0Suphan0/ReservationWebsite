using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }


        public void TAdd(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();
        }

        public Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
