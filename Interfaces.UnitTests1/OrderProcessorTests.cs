using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



//Everything is broken because the reference to Interfaces is broken
//They target different frameworks so it doesn't work.
namespace Interfaces.UnitTests1
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }


        [TestMethod]
        public void Processs_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order();

            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }


    }

    public class FakeShippnigCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }

    }

}
