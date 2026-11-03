using PortalSolicitacoes.Models;

namespace PortalSolicitacoes.Repositories
{
    public interface ISolicitanteRepositorio
    {
        List<SolicitanteModel> ListarTodos();
        SolicitanteModel? BuscarPorEmail(string email);
    }
}