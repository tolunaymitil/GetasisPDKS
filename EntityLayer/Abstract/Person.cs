using Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class Person : BaseEntity
    {
        public int IdentityNo { get; set; }
        public string FullName { get; set; }
        public GenderType Gender { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// 
        /// Parmak İzi veya Cihaz Üzerindeki Bilgileri İçin
        /// </summary>
        public string DeviceUniqueId { get; set; }
        public string DeviceCardNo { get; set; }
        public string DevicePassword { get; set; }
        public string DeviceVehicleCardNo { get; set; }

        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public PersonType PersonType { get; set; }
        public string Description { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Picture { get; set; }
        public string Address { get; set; }
    }
}
