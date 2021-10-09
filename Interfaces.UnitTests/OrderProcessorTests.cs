using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Interfaces.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
        }
    }


    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
