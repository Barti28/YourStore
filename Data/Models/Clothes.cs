﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourStore.Data.Models
{
    public class Clothes
    {
        public int ClothesId { get; set; }

        public string Name { get; set; }
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }

        public bool IsPreferredCloth { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }




    }
}
