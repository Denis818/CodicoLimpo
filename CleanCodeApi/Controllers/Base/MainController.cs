using CleanCodeApi.Interfaces;
using CleanCodeApi.Repository.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanCodeApi.Controllers.ControllerBase
{
    public class MainController : Controller
    {
        private readonly INotificadorErrosServices _notificador;

        public MainController(IServiceProvider serviceProvider)
        {
            _notificador = serviceProvider.GetRequiredService<INotificadorErrosServices>();
        }
        public async Task<IActionResult> CustomResponse<TResponse>(TResponse response)
        {            
            if(!_notificador.TemNotificacao() && response is null)
            {
                HttpContext.Response.StatusCode = 200;
                return Json(new ResponseDTO<TResponse> 
                {  
                    Success = true
                });
            }

            if (_notificador.TemNotificacao())
            {
                return BadRequest(new ResponseDTO<TResponse>
                {
                    Success = false,
                    Erros = _notificador.ListErros
                });
            }

            return Json(new ResponseDTO<TResponse>
            {
                Success = true,
                Data = response
            });
        }
    }

    public class ResponseDTO<TReturn>
    {
        public bool Success { get; set; }
        public TReturn Data { get; set; }   
        public List<string> Erros { get; set; }
    }
}
