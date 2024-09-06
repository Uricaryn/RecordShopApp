using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RechordShopApp.Enum;

namespace RechordShopApp.Concerete
{
    public class Album : BaseEntity
    {
        public string AlbumName { get; set; }

        public string Artist { get; set; }

        public DateTime ReleaseDate { get; set; }

        public  decimal Price { get; set; }

        public  int? DisctountRate { get; set; }

        public Status Status { get; set; }
        public Genre Genre { get; set; }

    }
}
