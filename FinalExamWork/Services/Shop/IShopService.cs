using FinalExamWork.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.Service
{
    public interface IShopService
    {
        void Create(ShopCreateModel shopCreateModel, int UserId);
        IndexPaginatorModel GetAll(bool Right, bool Left, string Name, int Page = 1);
        ShopDetailsModel GetDetailsModel(int Id, int CommentCount);
        void AddImage(int UserId, int Id, IFormFileCollection formFiles);

    }
}
