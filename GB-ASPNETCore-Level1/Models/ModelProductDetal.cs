using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class ModelProductDetal
    {
        public ModelShopProduct[] gallery1 = new ModelShopProduct[]
        {
            new ModelShopProduct("gallery1.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("gallery2.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("gallery3.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("gallery4.jpg","Легкое поло черного цвета", "$56"),
        };
        public ModelShopProduct[] gallery2 = new ModelShopProduct[]
        {
            new ModelShopProduct("gallery1.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("gallery3.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("gallery2.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("gallery4.jpg","Легкое поло черного цвета", "$56"),
        };
        public ModelShopProduct[] recommend = new ModelShopProduct[]
        {
            new ModelShopProduct("recommend1.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("recommend2.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("recommend3.jpg","Легкое поло черного цвета", "$56"),
        };
    }
}
