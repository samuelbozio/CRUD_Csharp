using BasicCrud.Context;
using BasicCrud.Models;
using BasicCrud.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BasicCrud.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(UsuarioModel usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public void Delete(UsuarioModel usuario)
        {
            _context.Remove(usuario);
            _context.SaveChanges();
        }

        public UsuarioModel Get(int id)
        {
            return _context.UsuarioModel.FirstOrDefault(x => x.Id == id);
        }

     

        public void Update(UsuarioModel usuario)
        {
            _context.Update(usuario);
            _context.SaveChanges();

          
        }
    }
}
