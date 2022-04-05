using System;
using System.Collections.Generic;
using System.Linq;
using Webapi.Entities;

namespace Webapi.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        private readonly System.Collections.Generic.List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "potion", Price = 9, CreateDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "sowrd", Price = 32, CreateDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "shield", Price = 22, CreateDate = DateTimeOffset.UtcNow },
        };



        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid Id)
        {
            return items.Where(item => item.Id == Id).FirstOrDefault();
        }




    }
}
