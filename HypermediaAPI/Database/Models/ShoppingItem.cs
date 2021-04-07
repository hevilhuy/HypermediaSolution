using System;

namespace HypermediaAPI.Database.Models
{
    public class ShoppingItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
