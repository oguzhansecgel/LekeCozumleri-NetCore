using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekeCozumleri.Entities.Concretes
{
    public class Stain
    {
        public int StainId { get; set; }
        public string StainName { get; set; }
        public string StainDescription { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
