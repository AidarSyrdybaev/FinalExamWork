using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamWork.DAL.Entites;
using FinalExamWork.Models;
using FinalExamWork.Service;
using Microsoft.AspNetCore.Authorization;
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
        public ActionResult Index( bool right, bool left, int Page, string Name)
        {   

            return View(ShopService.GetAll(right, left, Name,Page));
        }


        public ActionResult Details(int Id, int CommentCount)
        {
            var Model = ShopService.GetDetailsModel(Id, CommentCount);
            return View(Model);
        }

        [Authorize]
        public async Task<ActionResult> Create()
        {
            var Model = new ShopCreateModel();
            return View(Model);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(ShopCreateModel shopCreateModel)
        {
            var user = await UserManager.GetUserAsync(User);
            ShopService.Create(shopCreateModel, user.Id);
            return RedirectToAction("Index");
        }

       

       [Authorize]
        public IActionResult AddImage(int Id, IFormFileCollection Images)
        {
            var UserId = UserManager.GetUserId(User);
            ShopService.AddImage(int.Parse(UserId), Id, Images); ;
            return RedirectToAction("Details", new { Id = Id});
        }
    }
}
