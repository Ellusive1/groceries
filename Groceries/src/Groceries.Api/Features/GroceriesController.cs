using Microsoft.AspNetCore.Mvc;

namespace Groceries.Api.Features
{
    [ApiController]
    [Route("Groceries")]
    public class GroceriesController : ControllerBase
    {
        public static List<Grocery> Groceries = new List<Grocery>()
        {
            new Grocery()
            {
                Name = "Carottes",
                Id = 1
            },
            new Grocery()
            {
                Name = "Pommes",
                Id = 2
            }
        };

        [HttpGet]
        [Route("")]
        public List<Grocery> GetAll()
        {
 

            return Groceries;
        }

        [HttpGet]
        [Route("{groceryId}")]
        public Grocery GetOne(int groceryId)
        {
            var grocery = Groceries
                .Where(g => g.Id == groceryId)
                .FirstOrDefault();

            return grocery;
        }
    }   
}
