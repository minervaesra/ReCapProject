﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand :IEntities
    {
        public int BrandId { get; set; }
        public string BName { get; set; }
    }
}
