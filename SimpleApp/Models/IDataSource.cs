namespace SimpleApp.Models
{
    public interface IDataSource
    {
        IEnumerable<Product> Products =>
            new Product[]
            {
                new Product { Name = "Kayak", Price = 275M  },
                new Product { Name = "Lifejacket", Price = 48.95M }
            };

    }
}
