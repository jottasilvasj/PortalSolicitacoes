using PortalSolicitacoes.Models;
using PortalSolicitacoes.Models;

namespace PortalSolicitacoes.Repositories
{
    public interface IChamadosRepositorio
    {
        List<ChamadoModel> ListarTodos();
        ChamadoModel? BuscarPorId(int id);
        void Criar(ChamadoModel chamado);
        void AtualizarStatus(int id, string status, string? justificativaRejeicao = null);
    }
}