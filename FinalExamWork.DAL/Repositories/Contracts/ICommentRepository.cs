using FinalExamWork.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Repositories.Contracts
{
    public interface ICommentRepository: IRepository<Comment>
    {
        List<Comment> GetUserComments(int ShopId);
    }
}
