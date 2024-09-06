using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Interface;

namespace RechordShopApp.Concerete
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? DropDate { get; set; }

    }
}
