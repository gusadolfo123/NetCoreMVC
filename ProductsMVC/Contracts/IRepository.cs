using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsMVC.Models;

namespace ProductsMVC.Contracts
{
    public interface IRepository
    {
        List<Product> GetList();
        Product GetProductByID(int id);
    }
}
