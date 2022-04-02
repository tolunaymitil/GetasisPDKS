using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class PersonTaskManager:IPersonTaskService
    {
        IPersonTaskDal _personTaskDal;

        public PersonTaskManager(IPersonTaskDal personTaskDal)
        {
            _personTaskDal = personTaskDal;
        }

        public PersonTask GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonTask> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(PersonTask t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(PersonTask t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(PersonTask t)
        {
            throw new NotImplementedException();
        }
    }
}
