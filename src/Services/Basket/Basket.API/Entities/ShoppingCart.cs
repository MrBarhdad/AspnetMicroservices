﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string username)
        {
            this.UserName = username;
        }



        public decimal TotalPrice { get
            {
                decimal tolatprice = 0;
                foreach (var item in Items)
                {
                    tolatprice += item.Price * item.Quantity;
                }
                return tolatprice;
            } 
        }
    }
}
