using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    class ContactManager : IContactService
    {
        IContactDal _ContactDal;

        public ContactManager(IContactDal contactDal)
        {
            _ContactDal = contactDal;


        }
        public Contact GetByID(int id)
        {
            return _ContactDal.GetById(id);
        }

        public void TAdd(Contact t)
        {
            _ContactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public List<Contact> TGetList()
        {
           return _ContactDal.GetList();
        }

        public void TUpdate(Contact t)
        {
            ;_ContactDal.Update(t);
        }
    }
}
