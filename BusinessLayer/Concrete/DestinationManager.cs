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
    public class DestinationManager : IDestinationService
    {
        private IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }



        public List<Destination> GetAll()
        {
           return _destinationDal.GetAll();
        }

        public Destination GetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public void TAdd(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
