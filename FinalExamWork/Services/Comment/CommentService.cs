using FinalExamWork.DAL.Entites;
using FinalExamWork.DAL.Factories;
using FinalExamWork.DAL.Factories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWork.Services
{
    public class CommentService: ICommentService
    {   
        private IUnitOfWorkFactory UnitOfWorkFactory { get; }

        public CommentService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        public void CreateComment(int UserId, int ShopId, string Text, int Rate)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                bool CommentCheck = false;
                Comment comment = new Comment { Rate = Rate, Text = Text, UserId = UserId, ShopId = ShopId };
                foreach (var Comment in uow.Comments.GetAll())
                {
                    if (Comment.ShopId == ShopId && Comment.UserId == UserId)
                    {
                        CommentCheck = true;
                        break;
                    }
                }

                if (!CommentCheck)
                {
                    uow.Comments.Create(comment);
                    var Shop = uow.Shops.GetShopAndComments(ShopId);
                    double _Rate = RatingCalculate(Shop.Comments.ToList());
                    Shop.Raiting = _Rate;
                    uow.Shops.Update(Shop);
                }
            }
        }

        public void DeleteComment(int Id, int UserId)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                var Comment = uow.Comments.GetById(Id);
                var Shop = uow.Shops.GetShopAndComments(Comment.ShopId.Value);
                int id = Shop.Id;
                if (Shop.UserId == UserId)
                {
                    uow.Comments.Delete(Id);
                    Shop.Raiting = RatingCalculate(Shop.Comments.ToList());
                    uow.Shops.Update(Shop);
                }

               
            }
        }

        private double RatingCalculate(List<Comment> comments)
        {
            double Sum = comments.Sum(i => i.Rate);
            return Sum / comments.Count;
        }
    }
}
