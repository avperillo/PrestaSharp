﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestaSharp.Entities
{
    public class associations:prestashopentity
    {
        public List<address> addresses { get; set; }
    }
}