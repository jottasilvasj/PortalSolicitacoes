using PortalSolicitacoes.Models;

namespace PortalSolicitacoes.Repositories
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel? BuscarPorLogin(string email);
        void Cadastrar(UsuarioModel usuario);
    }
}