﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand entity);
        void Delete(Brand entity);
        void Update(Brand entity);
        List<Brand> GetAll();
        Brand GetById(int id);
    }
}
