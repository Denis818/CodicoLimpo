using CleanCodeApi.Controllers.ControllerBase;
using CleanCodeApi.Model;
using CleanCodeApi.Repository.Interfaces.IProdutos;
using CleanCodeApi.Repository.Service.ProdutoServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanCodeApi.Controllers.ControllersProduto
{
    [Route("[Controller]")]
    
    public class ProdutoController : MainController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IServiceProvider serviceProvider, IProdutoService produtoService) : base(serviceProvider)
        {
            _produtoService = produtoService;
        }

        public async Task<IActionResult> Index()
        {
            var result = _produtoService.GetProdutos();

            return await CustomResponse<IEnumerable<Produto>>(result);
        } 
    }
}
