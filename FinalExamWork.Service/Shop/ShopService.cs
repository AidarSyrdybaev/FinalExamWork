using AutoMapper;
using FinalExamWork.DAL.Entites;
using FinalExamWork.DAL.Factories;
using FinalExamWork.DAL.Factories.Contracts;
using FinalExamWork.Models;
using FinalExamWork.Service.File;
using System;
using System.Collections.Generic;
using System.Text;

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

        public List<Shop> GetAll()
        {
            using (var uow = UnitOfWorkFactory.CreateUnitOfWork())
            {
                return uow.Shops.GetAll();
            }
        }
    }
}
