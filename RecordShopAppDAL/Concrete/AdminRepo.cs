using RecordShopAppDAL.Context;
using RecordShopAppDAL.Interface;
using RechordShopApp.Concerete;

namespace RecordShopAppDAL.Concrete
{
    public class AdminRepo : BaseRepo<Admin>,IAdminRepo
    {
        public AdminRepo(AppDbContext context) : base(context)
        {
        }
    }
}
