using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DtoLayer.Stain
{
    public class CreateStainDto
    {
        public string StainName { get; set; }
        public string StainDescription { get; set; }

        public int CategoryId { get; set; }
    }
}
