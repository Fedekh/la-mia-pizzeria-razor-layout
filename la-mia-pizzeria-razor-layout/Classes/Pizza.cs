namespace la_mia_pizzeria_razor_layout.Classes
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }

        public double Price { get; set; }

        public Pizza(int number, string name, string description, string photo, double price)
        {
            Id = number;
            Name = name;
            Description = description;
            Photo = photo;
            Price = price;
        }

        public string GetPrice()
        {
            return this.Price.ToString("0.00");
        }

        public string GetDescription()
        {
            return this.Description;
        }
    }
}
