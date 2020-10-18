using FinalExamWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.Service
{
    public interface IShopService
    {
       void Create(ShopCreateModel shopCreateModel, int UserId);
        IndexPaginatorModel GetAll(bool Right, bool Left, int Page = 1);
        ShopDetailsModel GetDetailsModel(int Id, int CommentCount);
    }
}
