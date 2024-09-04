﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public  class ServiceManager :IGenericService<Service>
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
                _serviceDal = serviceDal;
        }
        public Service GetByID(int id)
        {
            return _serviceDal.GetById(id);
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
