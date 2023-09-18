using Anuncio.Data.Entities;
using Anuncio.Data.Repositories;
using Anuncio.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

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

        //capturar o submit 
        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var usuario = new Usuario();


                    usuario.Id = Guid.NewGuid();
                    usuario.Nome = model.Nome;
                    usuario.Email = model.Email;
                    usuario.Senha = model.Senha;
                    usuario.DataHoraCriacao = DateTime.Now;

                    //gravando no banco de dados
                    var usuarioRepository = new UsuarioRepository();

                    usuarioRepository.Add(usuario);

                    TempData["Mensagem"] = "Parabens sua conta foi cadastrada com sucesso!";
                }
                catch (Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

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
