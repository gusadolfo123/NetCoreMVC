using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsMVC.Contracts;

namespace ProductsMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository _Repository;

        public ProductController(IRepository repository)
        {
            _Repository = repository;
        }

        public IActionResult Index()
        {
            var products = _Repository.GetList();
            return View(products);
        }


        public IActionResult Details(int id)
        {
            var product = _Repository.GetProductByID(id);
            return View(product);
        }
    }
}