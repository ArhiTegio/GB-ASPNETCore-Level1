using Microsoft.AspNetCore.Mvc;
using WebStore.Models;


namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private ModelShopProduct[] product = new ModelShopProduct[]
        {
            new ModelShopProduct("product12.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product11.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product10.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product9.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product8.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product7.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product6.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product5.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product4.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product3.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product2.jpg","Легкое поло черного цвета", "$56"),
            new ModelShopProduct("product1.jpg","Легкое поло черного цвета", "$56"),
        };

        private ModelBlogPost[] blogPost = new ModelBlogPost[]
        {
            new ModelBlogPost("Розовые футболки для девушек прибыли в магазин", "Mac Doe", "13:33", "ДЕК 5, 2013", "blog-one.jpg", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." ),
            new ModelBlogPost("Розовые футболки для девушек прибыли в магазин", "Mac Doe", "13:33", "ДЕК 5, 2013", "blog-two.jpg", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." ),
            new ModelBlogPost("Розовые футболки для девушек прибыли в магазин", "Mac Doe", "13:33", "ДЕК 5, 2013", "blog-three.jpg", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." ),
        };

        private ModelProductDetal modelProductDetal = new ModelProductDetal();

        public IActionResult Index() => View(modelProductDetal);

        public IActionResult SomeAction() => View();

        public IActionResult Error404() => View();

        public IActionResult Blog() => View(blogPost);

        public IActionResult BlogSingle() => View();

        public IActionResult Cart() => View();

        public IActionResult CheckOut() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Login() => View();

        public IActionResult Shop() => View(product);

        public IActionResult ProductDetails() => View(modelProductDetal);
    }
}