using FinalExamWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.Service
{
    public interface IShopService
    {
       void Create(ShopCreateModel shopCreateModel, int UserId);
    }
}
