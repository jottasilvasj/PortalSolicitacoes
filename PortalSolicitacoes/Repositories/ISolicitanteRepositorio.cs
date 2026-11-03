using PortalSolicitacoes.Models;

namespace PortalSolicitacoes.Repositories
{
    public interface ISolicitanteRepositorio
    {
        List<SolicitanteModel> ListarTodos();
        SolicitanteModel? BuscarPorNome(string nome);
        int CriarEObterId(string nome);
    }
}