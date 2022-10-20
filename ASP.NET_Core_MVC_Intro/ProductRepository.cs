using static ASP.NET_Core_MVC_Intro.ProductRepository;
using System.Data;
using Dapper;

namespace ASP.NET_Core_MVC_Intro
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;");
        }

        
    }

}

