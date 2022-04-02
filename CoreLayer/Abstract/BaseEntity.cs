using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class BaseEntity 
    {
        [Key]
        public int ID { get; set; }
     

        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Oluşturulma Zamanı
        /// </summary>
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        /// <summary>
        /// Oluşturan Kullanıcı
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Güncellemenme Zamanı
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// Güncelleyen Kullanıcı
        /// </summary>
        public int? UpdatedBy { get; set; }

    }
}
