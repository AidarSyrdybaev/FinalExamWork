using AutoMapper;
using FinalExamWork.DAL.Entites;
using FinalExamWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.Service.AMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
        }

        public void ShopMapping()
        {
            CreateMap<Shop, ShopIndexModel>();
            CreateMap<ShopCreateModel, Shop>();

        }
    }
}
