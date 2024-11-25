using Microsoft.AspNetCore.Mvc.Filters;
using ButtonGrind.Models;
using ButtonGrind.Utlity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace RegisterAndLoginApp.Controllers { 
     class CustomAuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string userName = context.HttpContext.Session.GetString("username");
            if (userName == null)
            {
                context.Result = new RedirectResult("/login");
            }
            else
            {

            }
        }
    }
}
