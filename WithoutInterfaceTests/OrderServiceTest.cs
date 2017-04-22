using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Common.Logging;
using WithoutInterfaces;
using Xunit;
using Moq;

namespace WithoutInterfaceTests
{
    public class OrderServiceTest
    {
        [Fact]
        public async void OrderReturnsOk()
        {
            var logger = new Logger();
            var storageMock = new Mock<Storage>(logger);
            storageMock
                .Setup(s => s.Save())
                .Callback(() => logger.Log("mocked storage"))
                .Returns(Task.CompletedTask);

            var orderService = new OrderService(logger, storageMock.Object);

            var status = await orderService.Order();

            Assert.Equal(OrderStatus.Ok, status);
            Assert.True(logger.ToString().Contains("ordering logic"));
            Assert.False(logger.ToString().Contains("database"));
            Assert.True(logger.ToString().Contains("mocked storage"));
        }
    }
}
