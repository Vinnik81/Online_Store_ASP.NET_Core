﻿using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; } = new Category();

        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
    }
}
