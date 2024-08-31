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
    class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonailDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonailDal = testimonialDal;
        }
        public Testimonial GetByID(int id)
        {
            return _testimonailDal.GetById(id);
        }

        public void TAdd(Testimonial t)
        {
            _testimonailDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonailDal.Delete(t);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonailDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonailDal.Update(t);
        }
    }
}
