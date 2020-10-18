using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWork.Models
{
    public class ShopCreateModel

    {   
        [Required]
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        public int UserId { get; set; }

        [Required]
        [Display(Name = "Изображения")]
        public IFormFileCollection FormImages { get; set; }

    }
}
