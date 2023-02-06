namespace Lab4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Price<int>[] prices = new Price<int>[8];
            var r = new Random();

            for (int price_index = 0; price_index < prices.Length; price_index++)
            {
                //Console.WriteLine($"#{price_index+1}");
                //Console.Write("Введите имя товара: ");
                //string name = Console.ReadLine();
                //int id;
                //int priceRub;
                //bool success;

                //do
                //{
                //    Console.Write("Введите id: ");
                //    success = int.TryParse(Console.ReadLine(), out id);
                //} while (!success);

                //do
                //{
                //    Console.Write("Введите цену в рублях: ");
                //    success = int.TryParse(Console.ReadLine(), out priceRub);
                //} while (!success);

                //prices[price_index] = new Price<int>(id, name, priceRub);
                prices[price_index] = new Price<int>(r.Next(0,100), r.Next().ToString(), r.Next(0,100));
            }

            for (int price_index = 0; price_index < prices.Length; price_index++)
            {
                var price = prices[price_index];

                Console.ForegroundColor = price_index % 2 == 1 ? ConsoleColor.DarkCyan : ConsoleColor.White;
                Console.WriteLine($"Название товара: {price.Name} | ID: {price.Id} | Цена: {price.PriceRub} руб");

            }

            Array.Sort(prices);
            Console.WriteLine();

            for (int price_index = 0; price_index < prices.Length; price_index++)
            {
                var price = prices[price_index];

                Console.ForegroundColor = price_index % 2 == 1 ? ConsoleColor.DarkCyan : ConsoleColor.White;
                Console.WriteLine($"Название товара: {price.Name} | ID: {price.Id} | Цена: {price.PriceRub} руб");

            }

            Array.Sort(prices, new SortByPrice<int>());
            Console.WriteLine();

            for (int price_index = 0; price_index < prices.Length; price_index++)
            {
                var price = prices[price_index];

                Console.ForegroundColor = price_index % 2 == 1 ? ConsoleColor.DarkCyan : ConsoleColor.White;
                Console.WriteLine($"Название товара: {price.Name} | ID: {price.Id} | Цена: {price.PriceRub} руб");

            }
        }
    }
}
