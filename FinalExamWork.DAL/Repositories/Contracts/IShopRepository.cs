using FinalExamWork.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Repositories.Contracts
{
    public interface IShopRepository: IRepository<Shop>
    {
        List<Shop> GetFullShops();

        Shop GetFullShop(int Id);

        Shop GetShopAndComments(int Id);
    }
}
