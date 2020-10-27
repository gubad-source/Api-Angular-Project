﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
       [DatabaseGenerated (DatabaseGeneratedOption.None)]
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate  { get; set; }
        public string  AddedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
