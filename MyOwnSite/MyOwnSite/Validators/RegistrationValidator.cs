using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MyOwnSite.BusinessService;
using MyOwnSite.Interfaces;
using MyOwnSite.Models;







namespace MyOwnSite.Validators
{
    public class RegistrationValidator : IValidator
    {
        [Dependency]
        public IUserService UserService { get; set; }

        public ModelStateDictionary Dictionary { get; set; }

        public void Validate(UserForm form)
        {
            //UserService service = new UserService();
            //var nameExists = service.FindUserByLogin(form.Name);

            //if (nameExists != null)
            //{
            //    ModelStateDict.AddModelError("Name", "Login in use, try other one");
            //}





            if (Dictionary.IsValidField("Name") && UserService.FindUserByLogin(form.Name) != null)
            {
                //ModelStateDict.AddModelError("Name", "Login in use, try other one");
                Dictionary.AddModelError("Name", "Login is in use, try other one");
            }
            if (Dictionary.IsValidField("Email") && UserService.FindUserByEmail(form.Email) != null)
            {
                Dictionary.AddModelError("Email", "Email is in use, try other one");
            }
        }

    }
}