﻿using Microsoft.AspNetCore.Mvc;

namespace Anuncio.Presentation.Controlle
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Anuncie()
        {
            return View();
        }
    }
}
