namespace Groceries.Api.Data.Entities
{
    public class Grocery
    {
        public Grocery()
        {
        }

        public Grocery(string name)
        {
            Name = name;   
        }
        public string Name { get; set; }

        public int Id { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
