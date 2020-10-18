using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamWork.DAL.Entites;
using FinalExamWork.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamWork.Controllers
{
    public class CommentController : Controller
    {   
        private ICommentService CommentService { get; set; }

        private UserManager<User> UserManager { get; set; }

        public CommentController(ICommentService comment, UserManager<User> userManager)
        {
            CommentService = comment;
            UserManager = userManager;
        }

        // POST: CommentController/Create
        [HttpPost]
        public ActionResult Create(int ShopId, string Comment, int rating)
        {
            var user = UserManager.GetUserId(User);
            CommentService.CreateComment(int.Parse(user), ShopId, Comment, rating);
            return RedirectToAction("Details", "Shop", new{ Id = ShopId });
        }

        // POST: CommentController/Edit/5
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

        
        public ActionResult Delete(int Id, int ShopId)
        {   
           
            CommentService.DeleteComment(Id);
            return RedirectToAction("Details", "Shop", new { Id = ShopId});
        }
    }
}
