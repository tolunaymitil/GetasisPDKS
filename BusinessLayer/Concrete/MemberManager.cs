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
   public class MemberManager:IMemberService
    {
        IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public Member GetByID(int id)
        {
            return _memberDal.GetByID(x => x.ID == id);
        }

        public List<Member> GetList()
        {
            return _memberDal.GetListAll();
        }

        public void TAdd(Member t)
        {
            _memberDal.Insert(t);
        }

        public void TDelete(Member t)
        {
            _memberDal.Delete(t);
        }

        public void TUpdate(Member t)
        {
            _memberDal.Update(t);
        }
    }
}
