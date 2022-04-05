using System;
using System.Collections.Generic;
using Webapi.Entities;

namespace Webapi.Repositories
{
    public interface IInMemItemsRepository
    {
        Item GetItem(Guid Id);
        IEnumerable<Item> GetItems();
    }
}