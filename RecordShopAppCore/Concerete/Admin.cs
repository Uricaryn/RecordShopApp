using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechordShopApp.Concerete
{
    public class Admin : BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public  DateTime CreateDate { get; set; }
        public  DateTime DropDate { get; set; }
    }
}
