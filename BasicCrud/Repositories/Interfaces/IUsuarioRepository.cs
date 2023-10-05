using BasicCrud.Models;

namespace BasicCrud.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioModel Get(int id);
        void Add(UsuarioModel usuario);
        void Update(UsuarioModel usuario);
        void Delete(UsuarioModel usuario);
    }
}
