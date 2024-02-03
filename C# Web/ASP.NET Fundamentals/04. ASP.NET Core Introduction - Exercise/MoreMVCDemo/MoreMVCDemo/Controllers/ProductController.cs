using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MoreMVCDemo.Models;
using System.Text;
using System.Text.Json;

namespace MoreMVCDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly List<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name= "Cheese",
                Price = 15

            },

            new ProductViewModel()
            {
                Id = 2,
                Name= "Ham",
                Price = 25

            },

            new ProductViewModel()
            {
                Id = 3,
                Name= "Bread",
                Price = 2
            }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult ById(int id)
        {
            if(id < 0 || id >= products.Count)
            {
                TempData["Error"] = "No such product";

                return RedirectToAction(nameof(Index));
            }


            return View(products[id]);
        }

        public IActionResult AllAsJSON()
        {
           JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
           {
               WriteIndented = true,
           };
            return Json(products, jsonSerializerOptions);
        }

        public IActionResult AsPlainText() => Content(GetAllProductsAsString());
       
        /// <summary>
        /// Downloads Plain text as text.txt file
        /// </summary>
        /// <returns></returns>
        public IActionResult DownloadPlainText()
        {
            string content = GetAllProductsAsString();

            Response.Headers.Add(HeaderNames.ContentDisposition, @"attachment;filename=products.txt");

            return File(Encoding.UTF8.GetBytes(content), "text/plain");
        }

        public IActionResult Filtered(string? keyword)
        {
            if(keyword == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var model = products.Where(p => p.Name.ToLower().Contains(keyword));

            return View(nameof(Index), model);
        }

        private string GetAllProductsAsString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in products)
            {
                sb.AppendLine($"Product {item.Id}: {item.Name} - {item.Price} lv.");
            }

            return sb.ToString();
        }
    }
}
