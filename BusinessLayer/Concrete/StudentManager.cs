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
    public class StudentManager:IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public Student GetByID(int id)
        {
            return _studentDal.GetByID(x => x.ID == id);
        }

        public List<Student> GetList()
        {
            return _studentDal.GetListAll();
        }

        public void TAdd(Student t)
        {
            _studentDal.Insert(t);
        }

        public void TDelete(Student t)
        {
            _studentDal.Delete(t);
        }

        public void TUpdate(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
