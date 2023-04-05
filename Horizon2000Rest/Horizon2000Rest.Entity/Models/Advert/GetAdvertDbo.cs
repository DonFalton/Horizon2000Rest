using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon2000Rest.Entity.Models.Advert
{
    public class GetAdvertDbo
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string ImageFileType { get; set; }
    }
}
