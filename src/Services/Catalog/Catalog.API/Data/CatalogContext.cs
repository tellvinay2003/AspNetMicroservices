using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogRepository : ICatalogContext
    {

        public CatalogRepository(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettingd:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettingd:DatabaseName"));
            var collectonName = configuration.GetValue<string>("DatabaseSettingd:CollectionName");

            Products = database.GetCollection<Product>(collectonName);
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
