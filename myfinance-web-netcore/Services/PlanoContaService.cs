using myfinance_web_netcore.Domain;
using myfinance_web_netcore.infrastructure;

namespace myfinance_web_netcore.Services
{
    public class PlanoContaService : IPlanoContaService
    {
        private MyFinanceDBContext _myFinanceDbContext;

        public PlanoContaService(MyFinanceDBContext myFinanceDBContext)
        {
            _myFinanceDbContext = myFinanceDBContext;
        }
        public void Excluir(int Id)
        {
            throw new NotImplementedException();
        }
        public List<PlanoConta> ListarRegistros()
        {
           var lista = _myFinanceDbContext.PlanoConta.ToList();
            return lista;
        }

        public PlanoConta RetornarRegistro(int Id)
        {
            return new PlanoConta();
        }
        public void Salvar(PlanoConta item)
        {
            var dbSet = _myFinanceDbContext.PlanoConta;
            if(item.Id == null)
                dbSet.Add(item);
            else
            {
                dbSet.Attach(item);
                _myFinanceDbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _myFinanceDbContext.SaveChanges();

        }
    }
}