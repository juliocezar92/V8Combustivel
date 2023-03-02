using teste.Data;
using teste.Models;

namespace teste.Repositorio
{
    public class RelatorioRepositorio : IRelatorioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public RelatorioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        List<RelatorioModel> IRelatorioRepositorio.BuscarTodos()
        {
            return _bancoContext.Relatorios.ToList();
        }
        public RelatorioModel Adicionar(RelatorioModel relatorio)
        {
            _bancoContext.Relatorios.Add(relatorio);
            _bancoContext.SaveChanges();
            return relatorio;
        }

       
    }
}
