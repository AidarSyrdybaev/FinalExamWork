using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWork.Models
{
    public class ShopIndexModel
    {
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Автор:")]
        public string UserLogin { get; set; }
        [Display(Name = "Отзывов:")]
        public int CommetsCount { get; set; }
        [Display(Name = "Рейтинг")]
        public int Raiting { get; set; }

        public byte[] Image { get; set; }
    }
}
