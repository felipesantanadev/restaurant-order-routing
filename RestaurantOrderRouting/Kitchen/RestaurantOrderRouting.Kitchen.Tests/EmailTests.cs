using RestaurantOrderRouting.Kitchen.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestaurantOrderRouting.Kitchen.Tests
{
    public class EmailTests
    {
        [Theory]
        [InlineData("This is not an email.")]
        [InlineData("127.0.0.1")]
        [InlineData("www.email.com.br")]
        public void Invalid_Email_Should_Not_Be_Created(string value)
        {
            var email = Email.Create(value);
            Assert.False(email.IsSuccess);
        }

        [Theory]
        [InlineData("test@gmail.com")]
        [InlineData("test@gmail.com.br")]
        [InlineData("test@outlook.com")]
        [InlineData("test@outlook.com.br")]
        public void Valid_Email_Should_Be_Created(string value)
        {
            var email = Email.Create(value);
            Assert.True(email.IsSuccess);
        }
    }
}
