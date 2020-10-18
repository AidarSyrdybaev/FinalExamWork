using FinalExamWork.DAL.Context;
using FinalExamWork.DAL.Entites;
using FinalExamWork.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Repositories
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _Entities = applicationDbContext.Images;
        }

    }
}
