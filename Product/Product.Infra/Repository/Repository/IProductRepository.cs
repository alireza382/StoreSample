using Products.Application.Contract.Repository;
using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infra.Repository.Repository
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {
    }
}
