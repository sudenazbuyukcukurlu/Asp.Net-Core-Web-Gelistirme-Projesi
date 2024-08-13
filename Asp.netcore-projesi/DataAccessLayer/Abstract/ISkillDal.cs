using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    interface ISkillDal
    {
        void Insert (Skill p);
        void Delete (Skill p);
        void Update (Skill p);
        List<Skill> GetList();
    }
}
