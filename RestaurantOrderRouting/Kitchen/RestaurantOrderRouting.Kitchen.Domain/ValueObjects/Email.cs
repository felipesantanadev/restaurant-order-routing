using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Domain.ValueObjects
{
    public class Email : ValueObject<Email>
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Result<Email> Create(string email)
        {
            email = (email ?? string.Empty).Trim();

            if (email.Length == 0)
                return Result.Failure<Email>("Email should not be empty");

            if (email.Length > 150)
                return Result.Failure<Email>("Email is too long");

            if (!Regex.IsMatch(email, @"^(.+)@(.+)$"))
                return Result.Failure<Email>("Email is invalid");

            return Result.Success(new Email(email));
        }

        protected override bool EqualsCore(Email other)
        {
            return Value.Equals(other.Value, StringComparison.InvariantCultureIgnoreCase);
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }

        public static explicit operator Email(string email)
        {
            return Create(email).Value;
        }

        public static implicit operator string(Email email)
        {
            return email.Value;
        }
    }
}
