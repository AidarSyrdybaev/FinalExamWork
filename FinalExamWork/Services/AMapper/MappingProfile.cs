using AutoMapper;
using FinalExamWork.DAL.Entites;
using FinalExamWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamWork.Service.AMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ShopMapping();
        }

        public void ShopMapping()
        {
            CreateMap<Shop, ShopIndexModel>()
                .ForMember(source => source.UserLogin, target => target.MapFrom(i => i.User.Email))
                .ForMember(source => source.Image, target => target.MapFrom(i => i.Images.FirstOrDefault().Photo));
            CreateMap<ShopCreateModel, Shop>();
            CreateMap<Shop, ShopDetailsModel>().ForMember(i => i.Images, src => src.MapFrom(target => target.Images.ToList()));

        }
    }
}
