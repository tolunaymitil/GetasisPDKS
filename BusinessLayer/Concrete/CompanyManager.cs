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
    public class CompanyManager :ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public Company GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Company t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Company t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Company t)
        {
            throw new NotImplementedException();
        }
    }
}
