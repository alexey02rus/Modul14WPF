using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public enum ProdCateg
    {
        Еда,
        Техника
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public ProdCateg ProdCateg { get; set; }

        public Product(string name, double price, string image, ProdCateg prodCateg)
        {
            Name = name;
            Price = price;
            Image = image;
            ProdCateg = prodCateg;
        }
    }
}
