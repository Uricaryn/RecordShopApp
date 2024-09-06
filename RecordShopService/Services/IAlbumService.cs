using RechordShopApp.Enum;
using RecordShopService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShopService.Services
{
    public interface IAlbumService
    {
        int Create(AlbumCreateDto model);

        int Delete(int id);
        int Update(AlbumGetDto model);

        AlbumGetDto GetById(int id);
        IList<AlbumGetDto> GetAll();

    }
}
