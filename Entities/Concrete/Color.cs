using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntities
    {
        public int Id { get; set; }
        public string CName { get; set; }
    }
}
