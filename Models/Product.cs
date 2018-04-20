using System;
namespace BigPandaBakery.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
        }
    }
}
