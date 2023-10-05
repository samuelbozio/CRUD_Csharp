using BasicCrud.Context;
using BasicCrud.Models;
using BasicCrud.Repositories;
using BasicCrud.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BasicCrud.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
           UsuarioModel usuario =  _context.UsuarioModel.FirstOrDefault(x => x.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
            //Entender porquê é necessário o get e post do mesmo método

        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel usuario)
        {

            if (ModelState.IsValid)
            {
                _context.Update(usuario);
                _context.SaveChanges();
                return RedirectToAction("Usuarios");
            }

            return View();

        }


        public IActionResult Usuarios()
        {
            IEnumerable<UsuarioModel> usuarios = _context.UsuarioModel; //Chama uma lista de usuários.
            return View(usuarios);
        }

        public IActionResult Excluir(int? id)
        {

            var usuario = _context.UsuarioModel.FirstOrDefault(x => x.Id == id);
            _context.UsuarioModel.Remove(usuario);
            _context.SaveChanges();


            return RedirectToAction("Usuarios");
        }
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Usuarios");
            }
            return View();
        }
    }
}
