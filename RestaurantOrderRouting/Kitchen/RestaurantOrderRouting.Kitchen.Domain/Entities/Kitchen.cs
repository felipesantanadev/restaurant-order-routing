using RestaurantOrderRouting.Kitchen.Domain.Common;
using RestaurantOrderRouting.Kitchen.Domain.Exceptions;
using RestaurantOrderRouting.Kitchen.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Domain.Entities
{
    public class Kitchen : Entity
    {
        protected Kitchen() { }

        public Kitchen(string name, string pointOfSaleIdentifier, Email email)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidKitchenNameException();

            if (string.IsNullOrEmpty(pointOfSaleIdentifier))
                throw new InvalidLocationNameException();

            Name = name;
            NormalizedName = name.ToUpper();
            PointOfSaleIdentifier = pointOfSaleIdentifier;
            ContactEmail = email;
        }

        public string Name { get; private set; }
        public string NormalizedName { get; private set; }
        public string PointOfSaleIdentifier { get; private set; }
        public string ContactEmail { get; private set; }
        public virtual IList<Order> Orders { get; private set; } = new List<Order>();
    }
}
