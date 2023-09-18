﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string FirstPost { get; set; }
        public string FirstPostDescription { get; set; }
        public string FirstPostImage { get; set; }
        public bool Status { get; set; }

    }
}
