﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopDB.Repository;

namespace CoffeeShopDB.BLL
{
    class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(string name, double price)
        {
            return _itemRepository.Add(name, price);
        }
        public bool IsNameExists(string name)
        {
            return _itemRepository.IsNameExists(name);
        }

        public bool Delete(int id)
        {
            return _itemRepository.Delete(id);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
    }

}
}
