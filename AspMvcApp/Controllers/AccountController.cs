using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using AspMvcApp.Models;

namespace AspMvcApp.Controllers
{

    [HandleError]
    public class AccountController : Controller
    {

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(model.UserName, model.Password))
                {
                    AspDatabase db = new AspDatabase();

                    int logonResult = db.LogOnUser(model);

                    if (logonResult == 1)
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false);

                        var authTicket = new FormsAuthenticationTicket(model.UserName, false, 1);
                        string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                        var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                        HttpContext.Response.Cookies.Add(authCookie);

                        return RedirectToAction("Index", "Home");
                    }
                    else if (logonResult == 0)
                    {
                        ModelState.AddModelError("", "The user \"" + model.UserName + "\" doesn't exsist.");
                    }
                    else if (logonResult == -1)
                    {
                        ModelState.AddModelError("", "The password provided is incorrect.");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Something went wrong with database connection.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }
            else
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
            }

            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            RegisterModel register = new RegisterModel();
            return View(register);
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                if (ValidateUser(model.UserName, model.Password, model.ConfirmPassword))
                {
                    if (model.Password.Equals(model.ConfirmPassword))
                    {
                        AspDatabase db = new AspDatabase();

                        int registerResult = db.RegisterUser(model);

                        if (registerResult == 1)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else if (registerResult == 0)
                        {
                            ModelState.AddModelError("", "The user name provided is already used.");
                        }
                        else if (registerResult == -1)
                        {
                            ModelState.AddModelError("", "The password provided doesn't match the pattern.");
                        }
                        else if (registerResult == -3)
                        {
                            ModelState.AddModelError("", "Something went wrong with regular expressions. Received " + model.SelectedRegex);
                        }
                        else
                        {
                            ModelState.AddModelError("", "Something went wrong with database connection.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password and confirmation password doesn't match.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User name or password provided is incorrect.");
                }
            }
            return View(model);
        }

        public bool ValidateUser(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(password)) throw new ArgumentException("Value cannot be null or empty.", "password");

            return true;
        }

        public bool ValidateUser(string userName, string password, string confirmPassword)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(password)) throw new ArgumentException("Value cannot be null or empty.", "password");
            if (String.IsNullOrEmpty(confirmPassword)) throw new ArgumentException("Value cannot be null or empty.", "confirmPassword");

            return true;
        }
    }
}
