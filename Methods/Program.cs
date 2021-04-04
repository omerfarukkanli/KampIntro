using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Elma";
            product1.productSale = 15;
            product1.ProductAccount = "Amasya Elması";
            product1.Stock = 100;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Karpuz";
            product2.productSale = 80;
            product2.ProductAccount = "Diyarbakır Karpuzu";

            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Kavun";
            product3.productSale = 56;
            product3.ProductAccount = "kilis kavunu";
            x = 0;

            Product[] products = new Product[] {product1,product2,product3};
            foreach (Product product in products)
            {
                Console.WriteLine("Product name : " + product.ProductName);
                Console.WriteLine("Product Account : " + product.ProductAccount);
                Console.WriteLine("Sale :"+product.productSale);
                Console.WriteLine("Stock : "+product.Stock);
                if (x==2)
                {
                    break;
                }
                Console.WriteLine("-----------------");
                x++;
            }
            Console.WriteLine("-------------------------Methods---------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            

        }
    }
}
