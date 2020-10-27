using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Team:BaseEntity
    {
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
