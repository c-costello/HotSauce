using HotSauceApp.Models;
using HotSauceApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotSauceApp.Controllers
{
    //TODO: Add Authorization - ADMIN ONLY
    public class ProductsController : Controller
    {
        private readonly IProduct _ProductContext;

        public ProductsController(IProduct product)
        {
            _ProductContext = product;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _ProductContext.GetAllProducts());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _ProductContext.CreateProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Product product = await _ProductContext.GetProduct(id);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await _ProductContext.UpdateProduct(product);
            return Redirect("~/Products/Details/" + product.ID);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Product product = await _ProductContext.GetProduct(id);
            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Product product = await _ProductContext.GetProduct(id);
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirm(Product product)
        {
            Product productReal = await _ProductContext.GetProduct(product.ID);
            if (productReal.Name == product.Name)
            {
                await _ProductContext.DeleteProduct(product.ID);
                return RedirectToAction("Index");
            }
            //TODO send validation error; 
            return View(productReal);
        }
    }
}