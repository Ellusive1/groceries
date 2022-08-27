using Groceries.Api.Data.Entities;
using Groceries.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Groceries.Api.Features
{
    [ApiController]
    [Route("Groceries")]
    public class GroceriesController : ControllerBase
    {
        public GroceriesController(GroceryService groceryService)
        {
            GroceryService = groceryService;
        }

        public GroceryService GroceryService { get; }

        [HttpGet]
        [Route("")]
        public List<Grocery> GetAll()
        {
            return GroceryService.GetAll();
        }

        [HttpGet]
        [Route("{groceryId}")]
        public Grocery GetOne(int groceryId)
        {
            var grocery = GroceryService.Get(groceryId);

            return grocery;
        }

        [HttpPost]
        [Route("")]
        public Grocery Create(string name)
        {
            var grocery = GroceryService.Create(name);

            return grocery;
        }
    }   
}
