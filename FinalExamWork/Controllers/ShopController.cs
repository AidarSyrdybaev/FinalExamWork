using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamWork.DAL.Entites;
using FinalExamWork.Models;
using FinalExamWork.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamWork.Controllers
{
    public class ShopController : Controller
    {   
        private UserManager<User> UserManager { get; }
        private IShopService ShopService { get; }

        public ShopController(UserManager<User> userManager, IShopService shopService)
        {
            UserManager = userManager;
            ShopService = shopService;
        }
        // GET: ShopController
        public ActionResult Index( bool right, bool left, int Page)
        {   

            return View(ShopService.GetAll(right, left, Page));
        }


        public ActionResult Details(int Id, int CommentCount)
        {
            var Model = ShopService.GetDetailsModel(Id, CommentCount);
            return View(Model);
        }

        // GET: ShopController/Create
        public async Task<ActionResult> Create()
        {
            var Model = new ShopCreateModel();
            return View(Model);
        }

        // POST: ShopController/Create
        [HttpPost]
        public async Task<ActionResult> Create(ShopCreateModel shopCreateModel)
        {
            var user = await UserManager.GetUserAsync(User);
            ShopService.Create(shopCreateModel, user.Id);
            return RedirectToAction("Index");
        }

        // GET: ShopController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
