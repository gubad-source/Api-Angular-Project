using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Cards:BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
    }
}
