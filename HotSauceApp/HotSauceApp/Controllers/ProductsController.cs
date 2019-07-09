﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotSauceApp.Models;
using HotSauceApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            //TODO: redirect to Details rather than index
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Product product = await _ProductContext.GetProduct(id);
            return View(product);
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}