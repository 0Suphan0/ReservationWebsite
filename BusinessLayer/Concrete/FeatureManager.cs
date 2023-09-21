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
    public class FeatureManager : IFeatureService
    {
        private IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }


        public List<Feature> GetAll()
        {
           return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
