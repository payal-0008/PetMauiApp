using System;
using System.Collections.Generic;
using System.Text;

namespace PetMauiApp.Models
{
    public class CartItem
    {
        public string? Name { get; set; }
        public string? Weight { get; set; }
        public string? Image { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string TotalPriceDisplay => $"Rs {UnitPrice} x {Quantity}";
    }
}
