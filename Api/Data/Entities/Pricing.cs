using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Pricing:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public string Price { get; set; }
    }
}
