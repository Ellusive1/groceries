using Groceries.Api.Data;
using Groceries.Api.Data.Entities;

namespace Groceries.Api.Services
{
    public class GroceryService
    {   
        public GroceryService(GroceriesDbContext groceriesDbContext)
        {
            GroceriesDbContext = groceriesDbContext;
        }

        public GroceriesDbContext GroceriesDbContext { get; }

        public List<Grocery> GetAll()
        {
            return GroceriesDbContext.Groceries.ToList();
        }  

        public Grocery Create(string name)
        {
            var grocery = new Grocery(name);

            GroceriesDbContext.Groceries.Add(grocery);

            GroceriesDbContext.SaveChanges();

            return grocery;
        }
    }
}
