using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1,
                Name = "Test User"
            };
            Product product1 = new Product()
            {
                ProductId = 1,
                Name = "Product 1",
                Price = 100,
                Count = 10
            };
            Product product2 = new Product()
            {
                ProductId = 2,
                Name = "Product 2",
                Price = 200,
                Count = 20
            };
            Cart cart = new Cart(customer);
            var expectedResult = new List<Product>()
            {
                product1, product1, product2
            };

            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var cartResult = cart.GetAll();

            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for (int i = 0; i < expectedResult.Count; ++i)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }
        }
    }
}