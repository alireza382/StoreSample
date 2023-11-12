using Products.Infra.Repository;
using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Infra.Repository.Repository;

namespace Products.Infra.Repository
{
    public class ProductRepository : BaseRepository<Product>,IProductRepository
    {
    }
}
