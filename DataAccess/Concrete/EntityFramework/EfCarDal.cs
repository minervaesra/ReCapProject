using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join d in context.Colors on c.ColorId equals d.ColorId
                             select new ProductDetailDto()
                             {
                                 Id = c.Id,
                                 CarName = c.CarName,
                                 CName = d.CName,
                                 BName = b.BName,
                             };
                return result.ToList();
                             
            }
        }
    }
}
