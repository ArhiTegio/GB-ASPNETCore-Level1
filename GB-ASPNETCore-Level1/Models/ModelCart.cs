using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class ModelCart
    {
        public Item[] ItemInCart { get; set; }
        public string[] SingleField { get; set; }
        public string[] CityOrRegion { get; set; }

        public ModelCart(Item[] itemInCart, string[] singleField, string[] cityOrRegion)
        {
            ItemInCart = itemInCart;
            SingleField = singleField;
            CityOrRegion = cityOrRegion;
        }
    }

    public class Item
    {
        public string Pic { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string Priсe { get; set; }


        public Item(string name, string id, string priсe, string pic)
        {
            Name = name;
            ID = id;
            Priсe = priсe;
            Pic = pic;
        }
    }
}
