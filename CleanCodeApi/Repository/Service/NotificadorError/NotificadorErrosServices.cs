using CleanCodeApi.Interfaces;

namespace CleanCodeApi.Repository.Service.NotificadorError
{
    public class NotificadorErrosServices : INotificadorErrosServices
    {
        public List<string> ListErros { get; set; } = new List<string>();

        public void NotificarError(string mensagemErro)
        {
            ListErros.Add(mensagemErro);
        }
        public void LimparLista()
        {
            ListErros.Clear();
        }

        public bool TemNotificacao()
        {
            if (ListErros is not null && ListErros.Any())
            {
                return true;
            }
            return false;
        }
    }
}
