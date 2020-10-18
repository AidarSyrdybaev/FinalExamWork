using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Entites
{
    public class Shop: IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Raiting { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int CommentsCount { get; set; }

        public IEnumerable<Image> Images { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
