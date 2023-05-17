﻿using System.Collections;
using System.Collections.Generic;
using SalesWebMvc.Services;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
    