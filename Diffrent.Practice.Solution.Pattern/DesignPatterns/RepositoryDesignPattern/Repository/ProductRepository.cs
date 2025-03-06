using Diffrent.Practice.Solution.Pattern.DesignPatterns.RepositoryDesignPattern.Interfaces;
using Diffrent.Practice.Solution.Pattern.DesignPatterns.RepositoryDesignPattern.Models;

namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.RepositoryDesignPattern.Repository
{
    public class ProductRepository : IRepository<ProductModel>
    {
        private readonly List<ProductModel> _products = [];
        private int _nextId = 1;
        public void Add(ProductModel entity)
        {
            entity.Id = _nextId++;
            _products.Add(entity);
            Console.WriteLine($"Product {entity.Name} added.");
        }

        public IEnumerable<ProductModel> GetAll()
        {
            _products.Add(new ProductModel() { Id = _nextId, Name = "Abhitosh Kumar", Price = 300 });
            return _products;
        }

        public void Remove(ProductModel entity)
        {
            if (_products.Contains(entity) && entity.Price > 100)
            {
                {
                    _products.Remove(entity);
                    Console.WriteLine($"Product {entity.Name} removed.");
                }
            }
        }
    }
}
