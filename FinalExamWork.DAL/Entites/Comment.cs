using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Entites
{
    public class Comment: IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string Text { get; set; }

        public int Rate { get; set; }

        public DateTime DateTime { get; set; }

        public Shop Shop { get; set; }

        public int? ShopId { get; set; }
    }
}
