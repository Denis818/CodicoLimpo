using CleanCodeApi.Interfaces;
using CleanCodeApi.Model;
using CleanCodeApi.Repository.Interfaces.IProdutos;

namespace CleanCodeApi.Repository.Service.ProdutoServices
{
    public class ProdutoService : IProdutoService
    {
        private INotificadorErrosServices _notificadorErrosServices;

        public ProdutoService(INotificadorErrosServices notificadorErrosServices)
        {
            _notificadorErrosServices = notificadorErrosServices;
        }

        public List<Produto> GetProdutos()
        {
            if (false)
            {
                _notificadorErrosServices.NotificarError("voce não tem permissão para ver os produtos");
            }

            // imagine varios processos

            if (false)
            {
                _notificadorErrosServices.NotificarError("Outros errros");
                //return null;
            }

            return new List<Produto> {
                new Produto {  Id = 33, Nome = "Celuar", Preco = 3454.88 },
                new Produto { Id = 22, Nome = "Caderno", Preco = 24.99 },
                new Produto { Id = 11, Nome = "Computador", Preco = 38794.88 },
            };

            //return null;
        }
    }
}
