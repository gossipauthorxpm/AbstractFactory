namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Product product_milk = new Product("Молоко");
            Product product_cheese = new Product("Сыр");

            IFactory yandex = new YandexFactory(product_cheese)
            {
                name = "yandex",
                price = 400
            };

            IFactory amazon = new AmazonFactory(product_milk)
            {
                name = "amazon",
                price = 900
            };

            yandex.GetInfoOfDeliver();
            amazon.GetInfoOfDeliver();

        }
    }
}