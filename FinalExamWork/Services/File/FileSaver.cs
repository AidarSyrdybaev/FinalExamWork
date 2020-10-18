using FinalExamWork.DAL.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FinalExamWork.Service.File
{
    public class FileSaver : IFileSaver
    {
        public IEnumerable<Image> SaveAdvertisementImages(Shop shop, IFormFileCollection images)
        {
            foreach (var image in images)
            {
                yield return new Image { Photo = GetImageBytes(image), ShopId = shop.Id };
            }
        }
        public byte[] GetImageBytes(IFormFile formFile)
        {
            using (var binaryReader = new BinaryReader(formFile.OpenReadStream()))
            {
                return binaryReader.ReadBytes((int)formFile.Length);
            }
        }
    }
}
