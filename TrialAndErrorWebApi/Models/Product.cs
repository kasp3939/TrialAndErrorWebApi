namespace TrialAndErrorWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Product()
        { }

        public Product(int _id, string _name, string _category, decimal _price)
        {
            Id = _id;
            Name = _name;
            Category = _category;
            Price = _price;
        }
    }
}