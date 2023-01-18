using E_Shopping_App.Controllers;
using E_Shopping_App.Entities;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace E_Shopping_App.Data
{
    public interface ICatalogContext 
    {
        IMongoCollection<Product> Products { get; }

    }
}