﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StaffManager:IStaffService
    {
        IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public Staff GetByID(int id)
        {
            return _staffDal.GetByID(x => x.ID == id);
        }

        public List<Staff> GetList()
        {
          return  _staffDal.GetListAll();
        }

        public void TAdd(Staff t)
        {
            _staffDal.Insert(t);    
        }

        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
