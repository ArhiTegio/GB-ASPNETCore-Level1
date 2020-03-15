using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Data;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Interfaces;
using WebStore.ViewModels;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        public static AppDbContext context;

        public InMemoryProductData(AppDbContext context)
        {
            InMemoryProductData.context = context;
        }

        public IEnumerable<Section> GetSections() => context.Sections;

        public IEnumerable<Brand> GetBrands() => context.Brands;

        public IEnumerable<Product> GetProducts(ProductFilter Filter = null) => context.Products
            .Where(product => Filter == null || (Filter.SectionId == null || product.SectionId == Filter.SectionId))
            .Where(product => Filter == null || (Filter.BrandId == null || product.BrandId == Filter.BrandId));

        public void SaveChanges()
        {
            context.SaveChangesAsync();

        }
    }
}