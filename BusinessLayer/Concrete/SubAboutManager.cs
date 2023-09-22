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
    public class SubAboutManager : ISubAboutService
    {
        private ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal=subAboutDal;
        }

        public List<SubAbout> GetAll()
        {
           return _subAboutDal.GetAll();
        }

        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
