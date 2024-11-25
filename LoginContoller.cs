using ButtonGrind.Models;
using Microsoft.AspNetCore.Mvc;
using ButtonGrind.Services;
using Microsoft.Extensions.Logging;
using NLog;
using ButtonGrind.Utlity;

namespace ButtonGrind.Controllers
{
    // This controller handles actions related to user login
    public class LoginController : Controller
    {
        // Logger instance for tracking application activity
        private static Logger logger = LogManager.GetLogger("LoginAppLLoggerrule");

        // Action to display the login page
        public IActionResult Index()
        {
            return View();
        }

        // Action to process the login attempt
        public IActionResult ProcessLogin(UserModel user)
        {
            // Log the method entry and parameters
            logger.Info("Entering the ProcessLogin method");
            logger.Info("Parameter: " + user.ToString());
            MyLogger.GetInstance().Info("Entering the ProcessLogin method.");
            MyLogger.GetInstance().Info("Parameter: " + user.ToString());

            // Create an instance of the SecurityService for validation
            SecurityService securityService = new SecurityService();

            // Example for debugging - triggers a breakpoint for specific username
            if (user.UserName == "Bill Gates")
                System.Diagnostics.Debugger.Break();

            // Validate the user credentials
            if (securityService.IsValid(user))
            {
                // Log success
                MyLogger.GetInstance().Info("Login Success");
                // Set the username in the session
                HttpContext.Session.SetString("username", user.UserName);
                MyLogger.GetInstance().Info("Leaving the ProcessLogin method");

                logger.Info("Login Success");
                // Redirect to the login success page with user details
                return View("LoginSuccess", user);
            }
            else
            {
                // Log failure
                MyLogger.GetInstance().Info("Login Failure.");
                MyLogger.GetInstance().Info("Leaving the ProcessLogin method");
                // Remove the username from the session in case of failure
                HttpContext.Session.Remove("username");
                logger.Info("Login Failure");
                // Redirect to the login failure page with user details
                return View("LoginFailure", user);
            }
        }

        // Example of a custom action with an authorization attribute
        [HttpGet]
        [CustomAuthorization]
        public IActionResult PrivateSectionMustBeLoggedIn()
        {
            // Redirect to the Books index page if authorized
            return View("Books", "Index");
        }
    }
}
