using RestaurantOrderRouting.Order.Domain.Exceptions;
using Xunit;

namespace RestaurantOrderRouting.Order.Tests
{
    public class OrderTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Order_With_Invalid_Kitchen_Should_Throw_InvalidKitchenException(int kitchenId)
        {
            Assert.Throws<InvalidKitchenException>(() => new Order.Domain.Entities.Order(kitchenId));
        }

        [Fact]
        public void Items_With_Emtpy_Name_Should_Not_Be_Added_To_An_Order_And_Must_Throw_InvalidOrderItemNameException()
        {
            var order = new Order.Domain.Entities.Order(1);
            Assert.Throws<InvalidOrderItemNameException>(() => order.CreateNewItem(Crosscutting.Enum.KitchenAreas.Grill, string.Empty, "tag"));
        }

        [Fact]
        public void Items_With_Emtpy_ItemTag_Should_Not_Be_Added_To_An_Order_And_Must_Throw_InvalidOrderItemTagException()
        {
            var order = new Order.Domain.Entities.Order(1);
            Assert.Throws<InvalidOrderItemTagException>(() => order.CreateNewItem(Crosscutting.Enum.KitchenAreas.Grill, "Item Name", string.Empty));
        }
    }
}
