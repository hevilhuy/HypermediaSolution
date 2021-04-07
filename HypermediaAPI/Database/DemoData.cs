using HypermediaAPI.Database.Models;
using System;
using System.Collections.Generic;

namespace HypermediaAPI.Database
{
    public class DemoData
    {
        private static readonly Lazy<List<ShoppingItem>> _initShoppingItems = new(() =>
        {
            return new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "First item",
                    Price = 8.45d
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Second item",
                    Price = 23.4d
                }
            };
        });

        public static List<ShoppingItem> ShoppingItems { get => _initShoppingItems.Value; }
    }
}
