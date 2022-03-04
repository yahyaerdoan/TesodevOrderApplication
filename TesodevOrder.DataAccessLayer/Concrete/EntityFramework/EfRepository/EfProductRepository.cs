﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesodevOrder.DataAccessLayer.Abstract.IRepository;
using TesodevOrder.DataAccessLayer.Concrete.EntityFramework.Context;
using TesodevOrder.DataAccessLayer.Concrete.EntityFramework.EfGenericRepositories.EfGenericRepository;
using TesodevOrder.EntityLayer.Concrete.Models;

namespace TesodevOrder.DataAccessLayer.Concrete.EntityFramework.EfRepository
{
    public class EfProductRepository : EfGenericRepository<Product, TesodevOrderApplicationContext>, IProductRepository
    {
        private readonly IProductRepository _productRepository;
        public EfProductRepository(DbContext context, IProductRepository productRepository) : base(context)
        {
            _productRepository = productRepository;
        }
    }
}
