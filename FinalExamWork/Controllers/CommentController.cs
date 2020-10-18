using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalExamWork.DAL.Entites;
using FinalExamWork.Services;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpPost]
        public ActionResult Create(int ShopId, string Comment, int rating)
        {
            var user = UserManager.GetUserId(User);
            CommentService.CreateComment(int.Parse(user), ShopId, Comment, rating);
            return RedirectToAction("Details", "Shop", new{ Id = ShopId });
        }

        

        [Authorize]
        public ActionResult Delete(int Id, int ShopId)
        {
            var UserId = UserManager.GetUserId(User);
            CommentService.DeleteComment(Id, int.Parse(UserId));
            return RedirectToAction("Details", "Shop", new { Id = ShopId});
        }
    }
}
