using E_Shopping_App.Controllers;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using E_Shopping_App.Entities;
namespace E_Shopping_App.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }
        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Coloured joggers",
                    Type = "Trousers",
                    Size ="M"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Straight fit comfort jeans",
                    Type="Jeans",
                    Size="L"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Blue Spooky House Hoodie",
                    Type="Hoodies",
                    Size="M"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Xiaomi Mi 9",
                     Type="",
                    Size="M"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "HTC U11+ Plus",
                       Type="",
                    Size="M"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "LG G7 ThinQ",
                      Type="",
                    Size="M"
                }
            };

        }
    }
}