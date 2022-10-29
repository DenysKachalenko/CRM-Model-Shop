using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopComputerModel
    {
        Generator Generator = new Generator(); 
        Random Random = new Random();  
        bool IsRunning = false;


        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>(); 
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShopComputerModel()
        {
            var sellers = Generator.GetNewSellers(20);
            Generator.GetNewProducts(1000);
            Generator.GetNewProducts(100);

            foreach (var seller in sellers)
            {
                Sellers.Enqueue(seller);
            }

            for (int i = 0; i < 3; ++i)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }

        public void Start()
        {
            IsRunning = true;
            Task.Run(() => CreateCarts(10, 1000));

            var cashDeskTasks = CashDesks.Select(c => new Task(() => CashDeskWork(c, 1000)));
            foreach (var task in cashDeskTasks)
            {
                task.Start();
            }
        }

        public void Stop() 
        {
            IsRunning = false;
        }

        private void CashDeskWork(CashDesk cashDesk, int sleep)
        {
            while (IsRunning)
            {
                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(sleep);
                }
            }
        }

        private void CreateCarts(int customerCounts, int sleep)
        {
            while (IsRunning)
            {
                var customers = Generator.GetNewCustomers(customerCounts);

                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);

                    foreach (var product in Generator.GetRandomProducts(10, 30))
                    {
                        cart.Add(product);
                    }
                    var cash = CashDesks[Random.Next(CashDesks.Count - 1)];
                    cash.Enqueue(cart);
                }

                Thread.Sleep(sleep);
            }
        }
    }
}
