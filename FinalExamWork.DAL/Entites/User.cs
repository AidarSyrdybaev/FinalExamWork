using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamWork.DAL.Entites
{
    public class User: IdentityUser<int>, IEntity
    {
        public IEnumerable<Shop> Shops { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
        
        public IEnumerable<Image> Images { get; set; }
    }
}
