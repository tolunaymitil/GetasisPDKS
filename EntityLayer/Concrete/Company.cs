using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public int Name { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public bool Active { get; set; }
    }
}
