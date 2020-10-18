using FinalExamWork.DAL.Context;
using FinalExamWork.DAL.Entites;
using FinalExamWork.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamWork.DAL.Repositories
{
    public class ShopRepository: Repository<Shop>, IShopRepository
    {
        public ShopRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _Entities = applicationDbContext.Shops;
        }

        public List<Shop> GetFullShops()
        {
            return _Entities.Include(i => i.Images).Include(i => i.User).ToList();
        }

        public Shop GetFullShop(int Id)
        {
            return _Entities.Where(i => i.Id == Id).Include(i => i.User).Include(i => i.Images).Include(i => i.Comments).FirstOrDefault();
        }

        public Shop GetShopAndComments(int Id)
        {
            return _Entities.Where(i => i.Id == Id).Include(i => i.Comments).FirstOrDefault();
        }
    }
}
