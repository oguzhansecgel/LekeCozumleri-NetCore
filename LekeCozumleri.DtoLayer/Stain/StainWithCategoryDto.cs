using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.DtoLayer.Stain
{
    public class StainWithCategoryDto
    {
        public int StainId { get; set; }
        public string StainName { get; set; }
        public string StainDescription { get; set; }


        public string CategoryName { get; set; }
    }
}
