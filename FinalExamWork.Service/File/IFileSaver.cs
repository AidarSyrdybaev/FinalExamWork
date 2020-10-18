using FinalExamWork.DAL.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.Service.File
{
    public interface IFileSaver
    {
        
            byte[] GetImageBytes(IFormFile formFile);

            IEnumerable<Image> SaveAdvertisementImages(Shop shop, IFormFileCollection images);
        
    }
}
