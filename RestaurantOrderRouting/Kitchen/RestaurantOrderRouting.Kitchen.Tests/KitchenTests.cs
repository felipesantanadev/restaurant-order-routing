using RestaurantOrderRouting.Kitchen.Domain.Exceptions;
using RestaurantOrderRouting.Kitchen.Domain.ValueObjects;
using Xunit;

namespace RestaurantOrderRouting.Kitchen.Tests
{
    public class KitchenTests
    {
        [Fact]
        public void Kitchen_With_Emtpy_Name_Should_Throw_InvalidKitchenNameException_Exception()
        {
            var email = Email.Create("teste@gmail.com");

            Assert.Throws<InvalidKitchenNameException>(() => {
                new Kitchen.Domain.Entities.Kitchen(string.Empty, "Identifier", email.Value);
            });
        }

        [Fact]
        public void Kitchen_With_Emtpy_PointOfSaleIndentifier_Should_Throw_InvalidLocationNameException_Exception()
        {
            var email = Email.Create("teste@gmail.com");

            Assert.Throws<InvalidLocationNameException>(() => {
                new Kitchen.Domain.Entities.Kitchen("Test Kitchen", string.Empty, email.Value);
            });
        }
    }
}
