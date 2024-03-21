﻿using OnlineStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        //public ICartRepository Cart { get;  private set; }
        //public IApplicationUser ApplicationUser { get; private set; }
        //public IOrderHeaderRepository OrderHeader { get; private set; }
        //public IOrderDetailRepository OrderDetail { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
            Product = new ProductRepository(context);
            //Cart = new CartRepository(context);
            //ApplicationUser = new ApplicationUserRepository(context);
            //OrderHeader = new OrderHeaderRepository(context);
            //OrderDetail = new OrderDetailRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
