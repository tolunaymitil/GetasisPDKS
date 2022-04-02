using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStaffRepository:GenericRepository<Staff>,IStaffDal
    {
    }
}
