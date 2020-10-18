using FinalExamWork.DAL.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWork.Models
{
    public class ShopDetailsModel
    {
        public int Id { get; set; }
        [Display(Name ="Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Рейтинг")]
        public decimal Raiting { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int CommentPart => 10;

        public int CommentCount { get; set; }

        public IEnumerable<Image> Images { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
