using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab18_Coffee_Shop.Controllers
{
    public class UserRegistrationController : Controller
    {
        public IActionResult RegistrationForm()
        {
            return View(new RegisterUser());//returning a new instance of this user
        }
        

        public IActionResult DisplayUserInformation(RegisterUser user)
        {
            if (ModelState.IsValid)//if they filled out the form correctly then return the view
            {
              
               
                return View(user);
            }
            else
            {//if they did not then return the information on the registration form the user filled out
                return View("RegistrationForm", user);
            }
        }

        //find out why it is not displaying the second form 
        public IActionResult DisplayAllUserInformation(RegisterUser user)
        {
            return View(user);
        }

    }
}