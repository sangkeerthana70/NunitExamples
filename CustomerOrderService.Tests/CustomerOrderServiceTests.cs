using NUnit.Framework;
using CustomerOrderService;
using System;


namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class CustomerOrderServiceTests
    {
        [TestCase]
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            // A test case body is divided into three sections "AAA" denotes the Arrange, Act, and Assert.
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "George",
                CustomerType = CustomerType.Premium

            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 400
            };
            
            CustomerOrderService customerOrderService = new CustomerOrderService();
            //Act
            customerOrderService.ApplyDiscount(premiumCustomer, order);
            Console.WriteLine(order.Amount);
            //Assert
            Assert.AreEqual(order.Amount, 360);

        }
        [TestCase]
        public void When_SpecialCustomer_Expect_20PercentDiscount()
        {
            // A test case body is divided into three sections "AAA" denotes the Arrange, Act, and Assert.
            //Arrange
            Customer specialCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "Jasmine",
                CustomerType = CustomerType.SpecialCustomer

            };

            Order order = new Order
            {
                OrderId = 2,
                ProductId = 500,
                ProductQuantity = 2,
                Amount = 1000
            };

            CustomerOrderService customerOrderService = new CustomerOrderService();
            //Act
            customerOrderService.ApplyDiscount(specialCustomer, order);
            Console.WriteLine(order.Amount);
            //Assert
            Assert.AreEqual(order.Amount, 800);

        }


    }
}
