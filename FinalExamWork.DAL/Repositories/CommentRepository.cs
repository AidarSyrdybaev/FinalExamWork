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
    class CommentRepository: Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
        _Entities = applicationDbContext.Comments;
    }

        public List<Comment> GetUserComments(int ShopId)
        {
            return _Entities.Where(i => i.ShopId == ShopId).Include(i => i.User).ToList();
        }
}
}
