﻿using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepositoty Category { get; private set; }

        public IProductRepository Products {  get; private set; }
        public IProductImageRepositoty ProductImage { get; private set; }
        public ICompanyRepositoty Company { get; private set; }
        public IShoppingCartRepositoty ShoppingCart { get; private set; }
        public IApplicationUserRepositoty ApplicationUser { get; private set; }
        public IOrderDetailRepositoty OrderDetail { get; private set; }
        public IOrderHeaderRepositoty OrderHeader { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Products = new ProductRepository(_db);
            ProductImage = new ProductImageRepositoty(_db);
            Company = new CompanyRepository(_db);
            ShoppingCart = new ShoppingCartRepositoty(_db);
            ApplicationUser = new ApplicationUserRepositoty(_db);
            OrderDetail = new OrderDetailRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
