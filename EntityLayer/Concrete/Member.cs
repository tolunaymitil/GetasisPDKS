using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Member:Person
    {
        /// <summary>
        /// İşe Başlama Tarihi
        /// </summary>
        public DateTime? StartDateOfJob { get; set; }
        /// <summary>
        /// İşten Ayrılma Tarihi
        /// </summary>
        public DateTime? DismissalDate { get; set; }
        /// <summary>
        /// Sicil Numarası veya Firma Numarası
        /// </summary>
        public string RegistrationNumber { get; set; }
    }
}
