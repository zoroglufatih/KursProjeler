using Ilk_Mvc_Projesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ilk_Mvc_Projesi.Controllers
{
    public class ProductController : Controller
    {
        private readonly NorthwindContext _context;
        public ProductController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Products
                .Include(x=> x.Category)
                .OrderBy(x => x.ProductName)
                .ToList();
            return View(model);
        }
        public IActionResult Detail(int? id)
        {
            var product = _context.Products
                .Include(x => x.Category)
                .Include(x=> x.OrderDetails)
                .ThenInclude(x=> x.Order)
                .FirstOrDefault(x=> x.ProductId == id);
            if (product == null)
                return RedirectToAction(nameof(Index));
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var product = new Product()
            {
                ProductName = model.ProductName,
                UnitPrice = model.UnitPrice,
                CategoryId = model.CategoryId,
                Discontinued = model.Discontinued
                
            };
            _context.Products.Add(product);
            try
            {
                _context.SaveChanges();
                return RedirectToAction("Detail", new { id = product.CategoryId });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"{model.ProductName} eklenirken bir hata oluştu. Tekrar deneyiniz.");
                return View(model);
            }
            return View();
        }
    }
}
