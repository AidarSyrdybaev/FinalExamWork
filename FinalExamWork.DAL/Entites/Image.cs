using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Entites
{
    public class Image: IEntity
    {   
        public int Id { get; set; }

        public byte[] Photo { get; set; }

        public int ShopId { get; set; }

        public Shop Shop { get; set; }

        public User User { get; set; }

        public int? UserId { get; set; }
    }
}
