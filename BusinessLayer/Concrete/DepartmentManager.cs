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
    public class DepartmentManager:IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public Department GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Department t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Department t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Department t)
        {
            throw new NotImplementedException();
        }
    }
}
