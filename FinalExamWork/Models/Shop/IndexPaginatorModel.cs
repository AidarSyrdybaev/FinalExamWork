using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExamWork.Models
{
    public class IndexPaginatorModel
    {
        public int Page { get; set; }

        public int CurrentElementCount { get => Page * ElementCount; }

        public bool Left { get => Page > 1; }

        public int ElementCount => 20;

        public List<ShopIndexModel> Models { get; set; }
    }
}
