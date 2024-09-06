using RecordShopService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShopService.Services
{
    public interface IAdminService
    {
        int Create ( AdminCreateDto adminModel );

        int Update(AdminCreateDto adminModel,int id);

        int Delete  (int id);

        



    }
}
