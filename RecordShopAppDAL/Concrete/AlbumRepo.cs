using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Concerete;
using RecordShopAppDAL.Context;
using RecordShopAppDAL.Interface;

namespace RecordShopAppDAL.Concrete
{
    public class AlbumRepo : BaseRepo<Album>,IAlbumRepo
    {
        public AlbumRepo(AppDbContext context) : base(context)
        {
        }
    }
}
