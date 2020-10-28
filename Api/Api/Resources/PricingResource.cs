using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Resources
{
    public class PricingResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public string Price { get; set; }
    }
}
