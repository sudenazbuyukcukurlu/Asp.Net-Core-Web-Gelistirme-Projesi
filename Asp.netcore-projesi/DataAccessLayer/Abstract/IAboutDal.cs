using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    interface IAboutDal
    {
        void Insert(About p);
        void Update(About p);
        void Delete(About p);
        List<About> GetList();
    }
}
