﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbayView.Models.ViewModel.SubCategory
{
    public class CreateSubCategoryInputModel
    {
        public int SubCategoryId { get; set; }
        public int CatId { get; set; } 
        public string SubCatName { get; set; }
    }
}
