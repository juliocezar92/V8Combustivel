using teste.Models;

namespace teste.Repositorio
{
    public interface IRelatorioRepositorio
    {
        List<RelatorioModel>BuscarTodos();
        RelatorioModel Adicionar(RelatorioModel relatorio);
    }
}
