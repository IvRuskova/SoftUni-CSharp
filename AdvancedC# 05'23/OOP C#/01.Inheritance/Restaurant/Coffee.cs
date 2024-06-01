namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50m;
        
        public Coffee(string name, double cofeine) : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Cofeine = cofeine;
        }
        public double Cofeine { get; set; }

    }
}