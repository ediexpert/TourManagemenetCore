using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;

namespace AuthWithIdentity.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
        }
        public string Name { get; set; }
        public ItemViewModel Item { get; set; }
        // request format "2017-11-01T00:00:00"
        public DateTime ServiceDate { get; set; }

    }
    public class ItemViewModel
    {
        public int Quantity { get; set; }
    }
}
