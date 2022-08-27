namespace Groceries.Api
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
        
    }
}
