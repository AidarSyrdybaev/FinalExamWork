using AutoMapper;
using FinalExamWork.DAL.Entites;
using FinalExamWork.DAL.Factories;
using FinalExamWork.DAL.Factories.Contracts;
using FinalExamWork.Models;
using FinalExamWork.Service.File;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FinalExamWork.Service
{
    public class ShopService: IShopService
    {
        private IUnitOfWorkFactory UnitOfWorkFactory { get; set; }

        private IFileSaver _FileSaver { get; set; }

        public ShopService(IUnitOfWorkFactory unitOfWorkFactory, IFileSaver fileSaver)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
            _FileSaver = fileSaver;
        }

        public void Create(ShopCreateModel shopCreateModel, int UserId)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                var Shop = Mapper.Map<Shop>(shopCreateModel);
                Shop.UserId = UserId;

                uow.Shops.Create(Shop);

                var Images = _FileSaver.SaveAdvertisementImages(Shop, shopCreateModel.FormImages);

                foreach (var Image in Images)
                {
                    Image.UserId = UserId;
                    uow.Images.Create(Image);
                }

            }
        }

        public Shop Update()
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            { 
                
            }
            return null;
        }

        public Shop GetShop(int Id)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                return uow.Shops.GetById(Id);
            }
        }

        public void Delete(int Id)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                uow.Shops.Delete(Id);
            }
        }

        public IndexPaginatorModel GetAll(bool Right, bool Left, int Page = 1)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                var Model = new IndexPaginatorModel();
                var Shops = uow.Shops.GetFullShops();
                Model.Page = Page;
                if (Page == 0)
                {
                    Model.Page = 1;
                }
                else if (Right && Model.CurrentElementCount < Shops.Count)
                {
                    Model.Page++;
                }
                else if (Right && Model.CurrentElementCount > Shops.Count)
                {
                    Model.Page = Shops.Count / Model.ElementCount;
                }
                else if (Left && Model.Left)
                {
                    Model.Page--;
                }
                Model.Models = GetShops(Model, Shops);
                return Model;
            }
        }

        private List<ShopIndexModel> GetShops(IndexPaginatorModel model, List<Shop> shops)
        {
            var Shops = new List<Shop>();
            for (int i = (model.Page - 1) * model.ElementCount; i < model.Page * model.ElementCount && i <shops.Count; i++)
            {
                Shops.Add(shops[i]);
            }
            return Mapper.Map<List<ShopIndexModel>>(Shops);
        }



        public ShopDetailsModel GetDetailsModel(int Id, int CommentCount)
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {   
                var Model = Mapper.Map<ShopDetailsModel>(uow.Shops.GetFullShop(Id));
                Model.Comments = uow.Comments.GetUserComments(Id);
                Model.CommentCount = CommentCount;
                Model.CommentCount += Model.CommentPart;


                if (Model.Comments.Count > Model.CommentPart && Model.Comments.Count / Model.CommentPart > Model.CommentCount / Model.CommentPart )
                {
                    Model.Comments.RemoveRange(Model.CommentCount - 1, Model.Comments.Count - Model.CommentCount);
                }
                return Model;
            }
        }
    }
}
