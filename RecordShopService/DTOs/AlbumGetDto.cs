using RechordShopApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShopService.DTOs
{
    public class AlbumGetDto
    {
        public int Id { get; set; }

        public string AlbumName { get; set; }
      
        public string Artist { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Price { get; set; }

        public int? DisctountRate { get; set; }

        public Status Status { get; set; }
        public Genre Genre { get; set; }
        
    }
}
