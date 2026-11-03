using PortalSolicitacoes.Models;

namespace PortalSolicitacoes.Repositories
{
    public interface IChamadosRepositorio
    {
        List<ChamadoModel> ListarTodos();
        void Criar(ChamadoModel chamado);
    }
}