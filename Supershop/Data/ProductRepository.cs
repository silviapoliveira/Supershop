﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Supershop.Data.Entities;

namespace Supershop.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return _context.Products.Include(p => p.User);
        }
    }
}
