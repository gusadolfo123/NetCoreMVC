using ProductsMVC.Contracts;
using ProductsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsMVC.Models
{
    public class Repository : IRepository
    {

        private readonly List<Product> ProductList;

        public Repository()
        {
            ProductList = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Chai",
                    Category = "Beverages",
                    Price = (decimal)18.00,
                    UnitsInStock = 39
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Chang",
                    Category = "Beverages",
                    Price = (decimal)19.00,
                    UnitsInStock = 17
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Aniseed Syrup",
                    Category = "Condiments",
                    Price = (decimal)10.00,
                    UnitsInStock = 13
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Chef Anton's Cajun Seasoning",
                    Category = "Condiments",
                    Price = (decimal)22.00,
                    UnitsInStock = 53
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Chef Anton's Gumbo Mix",
                    Category = "Condiments",
                    Price = (decimal)21.35,
                    UnitsInStock = 0
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Grandma's Boysenberry Spread",
                    Category = "Condiments",
                    Price = (decimal)25.00,
                    UnitsInStock = 120
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Uncle Bob's Organic Dried Pears",
                    Category = "Produce",
                    Price = (decimal)30.00,
                    UnitsInStock = 15
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Northwoods Cranberry Sauce",
                    Category = "Condiments",
                    Price = (decimal)40.00,
                    UnitsInStock = 6
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Mishi Kobe Niku",
                    Category = "Meat/Poultry",
                    Price = (decimal)97.00,
                    UnitsInStock = 29
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Ikura",
                    Category = "Seafood",
                    Price = (decimal)31.00,
                    UnitsInStock = 31
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Queso Cabrales",
                    Category = "Dairy Products",
                    Price = (decimal)21.00,
                    UnitsInStock = 22
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Queso Manchego La Pastora",
                    Category = "Dairy Products",
                    Price = (decimal)38.00,
                    UnitsInStock = 86
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Konbu",
                    Category = "Seafood",
                    Price = (decimal)6.00,
                    UnitsInStock = 24
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Tofu",
                    Category = "Produce",
                    Price = (decimal)23.25,
                    UnitsInStock = 35
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Genen Shouyu",
                    Category = "Condiments",
                    Price = (decimal)15.50,
                    UnitsInStock = 39
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Pavlova",
                    Category = "Confections",
                    Price = (decimal)17.45,
                    UnitsInStock = 29
                },
                new Product
                {
                    ProductID = 17,
                    ProductName = "Alice Mutton",
                    Category = "Meat/Poultry",
                    Price = (decimal)39.00,
                    UnitsInStock = 0
                },
                new Product
                {
                    ProductID = 18,
                    ProductName = "Carnarvon Tigers",
                    Category = "Seafood",
                    Price = (decimal)62.50,
                    UnitsInStock = 42
                },
                new Product
                {
                    ProductID = 19,
                    ProductName = "Teatime Chocolate Biscuits",
                    Category = "Confections",
                    Price = (decimal)9.20,
                    UnitsInStock = 25
                },
                new Product
                {
                    ProductID = 20,
                    ProductName = "Sir Rodney's Marmalade",
                    Category = "Confections",
                    Price = (decimal)81.00,
                    UnitsInStock = 40
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = "Sir Rodney's Scones",
                    Category = "Confections",
                    Price = (decimal)10.00,
                    UnitsInStock = 3
                },
                new Product
                {
                    ProductID = 22,
                    ProductName = "Gustaf's Knäckebröd",
                    Category = "Grains/Cereals",
                    Price = (decimal)21.00,
                    UnitsInStock = 104
                },
                new Product
                {
                    ProductID = 23,
                    ProductName = "Tunnbröd",
                    Category = "Grains/Cereals",
                    Price = (decimal)9.00,
                    UnitsInStock = 61
                },
                new Product
                {
                    ProductID = 24,
                    ProductName = "Guaraná Fantástica",
                    Category = "Beverages",
                    Price = (decimal)4.50,
                    UnitsInStock = 20
                },
                new Product
                {
                    ProductID = 25,
                    ProductName = "NuNuCa Nuß-Nougat-Creme",
                    Category = "Confections",
                    Price = (decimal)14.00,
                    UnitsInStock = 76
                },
                new Product
                {
                    ProductID = 26,
                    ProductName = "Gumbär Gummibärchen",
                    Category = "Confections",
                    Price = (decimal)31.23,
                    UnitsInStock = 15
                },
                new Product
                {
                    ProductID = 27,
                    ProductName = "Schoggi Schokolade",
                    Category = "Confections",
                    Price = (decimal)43.90,
                    UnitsInStock = 49
                },
                new Product
                {
                    ProductID = 28,
                    ProductName = "Rössle Sauerkraut",
                    Category = "Produce",
                    Price = (decimal)45.60,
                    UnitsInStock = 26
                },
                new Product
                {
                    ProductID = 29,
                    ProductName = "Thüringer Rostbratwurst",
                    Category = "Meat/Poultry",
                    Price = (decimal)123.79,
                    UnitsInStock = 0
                },
                new Product
                {
                    ProductID = 30,
                    ProductName = "Nord-Ost Matjeshering",
                    Category = "Seafood",
                    Price = (decimal)25.89,
                    UnitsInStock = 10
                }
            };
        }

        public List<Product> GetList()
        {
            return this.ProductList;
        }

        public Product GetProductByID(int ProductID) 
        {
            return this.ProductList.Find(x => x.ProductID == ProductID);
        }
    }
}
