﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Resources
{
    public class ServicesResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        public string Header { get; set; }
        public string Info { get; set; }
    }
}