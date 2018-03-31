using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MyOwnSite.BusinessService;
using MyOwnSite.Models;
using MyOwnSite;

namespace MyOwnSite.Controllers
{
    public class PostApiController : ApiController
    {
        [Dependency]
    //123321TEST
    //9999
<<<<<<< HEAD
    //666
=======
    //666777
>>>>>>> Test1
        public IPostService PostService { get; set; }

        [Dependency]

        public ICommentService CommentService { get; set; }



        [Dependency]

        public IUserService UserService { get; set; }

        
        [ValidateAntiForgeryToken]
        
        public HttpResponseMessage Post( Post post)
        {
            if (ModelState.IsValid)
            {

                var name = System.Web.HttpContext.Current.User.Identity.Name;

                var user = UserService.FindUserByLogin(name);

                post.UserId = user.UserId;

                PostService.Insert(post);

                return new HttpResponseMessage(HttpStatusCode.Created);
            }

            var errors = new List<string>();
            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    errors.Add(error.ErrorMessage);
                }
            }
            return Request.CreateResponse(HttpStatusCode.Forbidden, errors);



            //return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
        [System.Web.Http.HttpGet]
        public List<Post> Get()
        {

            //var ctx = new UserContext();
            //var posts = from s in ctx.Posts select s;
            var posts = PostService.List();


            //List<string> posts = new List<string>() {"TEST1", "HttpGet"};

            return posts;
        }

        
    }
}