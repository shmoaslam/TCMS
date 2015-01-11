﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCMS.Models
{
    public class BaseModel
    {
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}