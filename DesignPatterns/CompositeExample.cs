namespace DesignPatterns.CompositeExample
{
    abstract class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display(int depth);
        public abstract decimal GetPrice();
    }

    class Category : MenuItem
    {
        private List<MenuItem> items = new List<MenuItem>();

        public Category(string name) : base(name, 0) { }

        public void Add(MenuItem item)
        {
            items.Add(item);
        }

        public void Remove(MenuItem item)
        {
            items.Remove(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " Категорія: " + Name);
            foreach (var item in items)
            {
                item.Display(depth + 2);
            }
        }

        public override decimal GetPrice()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }

    class Dish : MenuItem
    {
        public Dish(string name, decimal price) : base(name, price) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + $" Страва: {Name}, Ціна: {Price} грн");
        }

        public override decimal GetPrice()
        {
            return Price;
        }
    }
}
