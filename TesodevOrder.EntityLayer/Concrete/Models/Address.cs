﻿using System;
using System.Collections.Generic;
using TesodevOrder.CoreLayer.Concrete.Entities;

#nullable disable

namespace TesodevOrder.EntityLayer.Concrete.Models
{
    public partial class Address : Entity
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CityCode { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
