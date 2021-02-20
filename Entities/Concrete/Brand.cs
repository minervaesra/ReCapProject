using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand :IEntities
    {
        public int Id { get; set; }
        public string BName { get; set; }
    }
}
