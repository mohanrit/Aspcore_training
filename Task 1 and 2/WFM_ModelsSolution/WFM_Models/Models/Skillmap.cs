﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WFM_Models.Models
{
    public class Skillmap
    {
        public int employee_id { get; set; }
        public Skills skills { get; set; }
        public Employee employee { get; set; }
        public int skillid { get; set; }

    }
}
