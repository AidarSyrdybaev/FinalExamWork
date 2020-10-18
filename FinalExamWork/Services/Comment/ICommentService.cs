using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWork.Services
{
    public interface ICommentService
    {
        void CreateComment(int UserId, int ShopId, string Text, int Rate);

        void DeleteComment(int Id, int UserId);


    }
}
