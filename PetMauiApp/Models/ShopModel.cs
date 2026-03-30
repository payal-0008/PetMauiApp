using System;
using System.Collections.Generic;
using System.Text;

namespace PetMauiApp.Models
{
    public class ShopModel
    {
        public class ProductModel
        {
            public string? Name { get; set; }  
            public string? Brand { get; set; }  
            public string? Weight { get; set; }  
            public string? Price { get; set; }  
            public string? Image { get; set; }  
            public string? Tag { get; set; }  
            public string? TagColor { get; set; }
            public string? Category { get; set; }
        
        }
    }
}
